using Automacao.UI.Bases;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Automacao.UI.Pages
{
    public class BuscaCepPage : PageBase
    {
        #region Mapeamento
        By CepField = By.Id("relaxation");
        By SearchButton = By.XPath("(//button[@class='bt-link-ic']//i[@class='ic-busca-out'])[2]");
        By MensagemSucesso = By.XPath("//td[contains(text(),'Rua Quinze de Novembro - lado ímpar')]");
        By MensagemDadosIncorretos = By.XPath("//div[@class='mensagem']//h6[contains(text(),'Dados não encontrado')]");
        #endregion

        #region Ações
        public void PreencherCEP(string cep)
        {
            SendKeys(CepField, cep);
        }

        public void ClicarBuscar()
        {
            Click(SearchButton);
        }
        #endregion

        #region Verificações
        public void VerificaSeCEPIncorreto()
        {
            Assert.IsTrue(driver.FindElement(MensagemDadosIncorretos).Displayed);
        }

        public void VerificaSeMensagemSucessoeExibida()
        {
            Assert.IsTrue(driver.FindElement(MensagemSucesso).Displayed);
        }
        #endregion
    }
}
