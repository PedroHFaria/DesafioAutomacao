using Automacao.UI.Helpers;
using Automacao.UI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Runtime.ConstrainedExecution;
using TechTalk.SpecFlow;

namespace Automacao.UI.StepDefinitions
{
    [Binding]
    public class BuscaCEPStepDefinitions
    {

        BuscaCepPage buscaCepPage;
       

        public BuscaCEPStepDefinitions()
        {
            buscaCepPage = new BuscaCepPage();
        }


        [StepDefinition(@"que acesse o site correios")]
        public void GivenQueAcesseOSiteCorreios()
        {
            DriverFactory.INSTANCE.Navigate().GoToUrl(ConfigurationManager.AppSettings["base_url_qa"]);
        }

        [StepDefinition(@"o site deve retornar que endereco nao existe")]
        public void ThenOSiteDeveRetornarQueEnderecoNaoExiste()
        {
            buscaCepPage.VerificaSeCEPIncorreto();
        }

        [StepDefinition(@"voltar para a tela inicial")]
        public void ThenVoltarParaATelaInicial()
        {
            DriverFactory.INSTANCE.Navigate().GoToUrl(ConfigurationManager.AppSettings["base_url_qa"]);
            //    DriverFactory.INSTANCE.Navigate().GoToUrl("https://www.correios.com.br/");
        }


        [StepDefinition(@"desejo buscar um cep inexistente")]
        public void WhenDesejoBuscarUmCepInexistente()
        {
            buscaCepPage.PreencherCEP("80700000");
            buscaCepPage.ClicarBuscar();
        }

        [StepDefinition(@"desejo buscar um cep correto")]
        public void WhenDesejoBuscarUmCepCorreto()
        {
            buscaCepPage.PreencherCEP("01013-001");
            buscaCepPage.ClicarBuscar();
        }

        [StepDefinition(@"o site deve retornar o endereco Rua Quinze de Novembro, São Paulo/SP com sucesso")]
        public void ThenOSiteDeveRetornarOEnderecoRuaQuinzeDeNovembroSaoPauloSPComSucesso()
        {
            buscaCepPage.VerificaSeMensagemSucessoeExibida();
        }

    }
}
