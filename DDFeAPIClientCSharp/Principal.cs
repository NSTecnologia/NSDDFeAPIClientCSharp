using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDFeAPIClientCSharp
{
    class Principal
    {
        static void Main(string[] args)
        {
            /*
              Aqui voce pode testar a chamada de metodos para manifestar,
              fazer o download de um unico documento ou/e fazer download de
              varios documentos emitidos contra co CNPJ do cliente

              - Aqui um exemplo de chamada de download de um unico documento atraves da chave
                (pode ser feito tanto pela chave do documento ou pelo NSU do mesmo):

                  * String resposta = DDFeAPI.downloadUnico(CNPJInteressado, caminho, tpAmb, nsu, modelo, chave,
                                      incluirPdf, apenasComXml, comEventos);


              - Aqui um exemplo de chamada de download de lote de documentos
                (pode ser feito pelo ultimo NSU ou pela data inicial e data final):

                  * String resposta = DDFeAPI.downloadLote(CNPJInteressado, caminho, tpAmb, ultNSU, dhInicial, dhFinal, modelo,
                                        apenasPendManif, incluirPdf, apenasComXml, comEventos);
              - Aqui um exemplo de chamada do evento de manifestação
                    * String resposta = DDFeAPI.manifestacao(CNPJInteressado, tpEvento, nsu, xJust, chave);

              Para maiores informações, consulte a documentação no link: https://docsnstecnologia.wpcomstaging.com/docs/ns-ddfe/consumo-da-api-ns-ddfe/download-de-documentos/, e entre em contato com a equipe de integração
           */
            string CNPJInteressado = "07364617000135";
            string tpEvento = "210200";
            string nsu = "";
            string xJust = "";
            string chave = "43210400063354950072559200000009241538520136";
            String resposta = DDFeAPI.manifestacao(CNPJInteressado, tpEvento, nsu, xJust, chave);
        }
    }
}
