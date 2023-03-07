using Automacao.UI.Helpers;
using Automacao.UI.Pages;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace Automacao.UI.StepDefinitions
{
    [Binding]
    public class BuscaCodigoDeRastreamentoStepDefinitions
    {

        PesquisaCodRastreamentoPage pesquisacodrastreamentoPage;

        public BuscaCodigoDeRastreamentoStepDefinitions()
        {
            pesquisacodrastreamentoPage = new PesquisaCodRastreamentoPage();
        }

        [StepDefinition(@"desejar busca o SS(.*)BR")]
        public void WhenDesejarBuscaOSSBR(string rastreio)
        {
            pesquisacodrastreamentoPage.PreencherCodRastreio(rastreio);
            pesquisacodrastreamentoPage.ClicarBuscar();
            pesquisacodrastreamentoPage.ClicarSegundaPagina();
        }

        [StepDefinition(@"o site deve retornar que codigo de rastreamento nao existe")]
        public void ThenOSiteDeveRetornarQueCodigoDeRastreamentoNaoExiste()
        {
            pesquisacodrastreamentoPage.VerificaSeCodRastreioIncorreto();
        }

        [StepDefinition(@"fechar o navegador")]
        public void ThenFecharONavegador()
        {
            DriverFactory.INSTANCE.Quit();
        }
    }
}
