using Newtonsoft.Json;
using PubApi.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PubApi
{
    public class ApiWeb
    {
        public struct HttpResult
        {
            public Boolean Erro;
            public string MensagemErro;
        }

        public HttpResult httpResult;

        int idUsuario;
        string secret;
        
        string rtBaseUrl = "";
        string rtPublicacao = "/publicacao";
        string rtStatus = "/statusPublicacao";
        string rtModallidade = "/modalidade";
        string rtItens = "/itensProcesso?numero=<paramNumero>&ano=<paramAno>";


        public ApiWeb(int idUs, string senhaUs, string url)
        {
            idUsuario = idUs;
            secret = senhaUs;
            if (!string.IsNullOrWhiteSpace(url)) rtBaseUrl = url;
        }


        private string GetSignature(int idUsuario, string secret, string nonce, object obj)
        {
            string texto = nonce + idUsuario.ToString();

            if (obj != null) texto = texto + JsonConvert.SerializeObject(obj);

            return GerarHash(texto, secret);
        }


        private string GetTimeStamp()
        {
            long nonce = Convert.ToInt64(TimeSpan.FromTicks(DateTime.UtcNow.Ticks).TotalMilliseconds);
            return nonce.ToString();
        }


        private string GerarHash(string texto, string secret)
        {
            HMACSHA256 hashMaker;
            hashMaker = new HMACSHA256(Encoding.UTF8.GetBytes(secret));

            byte[] data = Encoding.UTF8.GetBytes(texto);
            byte[] hash = hashMaker.ComputeHash(data);
            string signature = GetHexString(hash);

            return signature;
        }


        private string GetHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                sb.Append(String.Format("{0:x2}", b));
            }

            return sb.ToString();
        }

        private string ValidarRetorno(string response)
        {
            ResponseData resp = JsonConvert.DeserializeObject<ResponseData>(response);

            if (!resp.Error)
            {
                return resp.Data.ToString();
            }
            else
            {
                httpResult.Erro = true;
                httpResult.MensagemErro = resp.Message;

                return "";
            }
        }


        private string SendRequest(string url, object obj, string metodo)
        {
            string nonce = GetTimeStamp();

            string signRequest = GetSignature(idUsuario, secret, nonce, obj);

            HttpWebRequest wr = WebRequest.Create(url) as HttpWebRequest;
            wr.ContentType = "application/json";
            wr.Headers.Add("PUB_API_USER", idUsuario.ToString());
            wr.Headers.Add("PUB_API_TIMESTAMP", nonce);
            wr.Headers.Add("PUB_API_SIGN", signRequest);
            wr.Method = metodo;

            string response = null;

            try
            {
                // adiciona obj ao corpo da requisição
                if (obj != null && metodo == "POST")
                {
                    using (var streamWriter = new StreamWriter(wr.GetRequestStream()))
                    {
                        string json = JsonConvert.SerializeObject(obj);
                        streamWriter.Write(json);
                    }
                }

                HttpWebResponse resp = wr.GetResponse() as HttpWebResponse;
                StreamReader sr = new StreamReader(resp.GetResponseStream());
                response = sr.ReadToEnd();
                sr.Close();

                httpResult.Erro = false;
                httpResult.MensagemErro = "";

                response = ValidarRetorno(response);
            }
            catch (WebException ex)
            {
                httpResult.Erro = true;
                httpResult.MensagemErro = ex.Message;
                response = "";
            }

            return response;
        }


        public List<PublicacaoProcesso> ConsultarPublicacao(int numeroProcesso, int anoProcesso)
        {
            string url = rtBaseUrl + rtPublicacao;
            string metodo = "POST";

            RequestData obj = new RequestData { NumeroProcesso = numeroProcesso.ToString(), AnoProcesso = anoProcesso.ToString() };
            string response = SendRequest(url, obj, metodo);

            List<PublicacaoProcesso> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<PublicacaoProcesso>>(response);
            }

            return lista;
        }

        public List<ItemProcesso> ConsultarItens(int numeroProcesso, int anoProcesso)
        {
            string url = rtBaseUrl + rtItens.Replace("<paramNumero>", numeroProcesso.ToString()).Replace("<paramAno>", anoProcesso.ToString());

            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<ItemProcesso> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<ItemProcesso>>(response);
            }

            return lista;
        }

        public List<StatusPublicacaoProcesso> ConsultarStatusPublicacao()
        {
            string url = rtBaseUrl + rtStatus;
            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<StatusPublicacaoProcesso> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<StatusPublicacaoProcesso>>(response);
            }

            return lista;
        }

        public List<ModalidadeDto> ConsultarModalidade()
        {
            string url = rtBaseUrl + rtModallidade;
            string metodo = "GET";

            string response = SendRequest(url, null, metodo);

            List<ModalidadeDto> lista = null;

            if (!string.IsNullOrWhiteSpace(response))
            {
                lista = JsonConvert.DeserializeObject<List<ModalidadeDto>>(response);
            }

            return lista;
        }

    }
}
