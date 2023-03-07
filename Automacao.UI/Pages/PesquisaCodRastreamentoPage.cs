using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Automacao.UI.Bases;

namespace Automacao.UI.Pages
{
    public class PesquisaCodRastreamentoPage : PageBase
    {
        #region Mapeamento
        By RastreioField = By.Id("objetos");
        By SearchRastreioButton = By.XPath("(//button[@class='bt-link-ic']//i[@class='ic-busca-out'])[1]");
        By SearchRastreioSecondButton = By.Id("b-pesquisar");
        By CodIncorreto = By.XPath("//div[contains(text(), 'Código de objeto, CPF ou CNPJ  informado não está válido')]");
        #endregion

    #region Ações
    public void PreencherCodRastreio(string rastreio)
    {
        SendKeys(RastreioField, rastreio);
    }

    public void ClicarBuscar()
    {
        Click(SearchRastreioButton);
    }

    public void ClicarSegundaPagina()
    {
        driver.SwitchTo().Window(driver.WindowHandles[1]);
        Click(SearchRastreioSecondButton);
    }
    #endregion

    #region Verificações
    public void VerificaSeCodRastreioIncorreto()
    {
        Assert.IsTrue(driver.FindElement(CodIncorreto).Displayed);
    }

    public void VerificaSeMensagemSucessoeExibida()
    {
        Assert.IsFalse(driver.FindElement(CodIncorreto).Displayed);
    }
    #endregion
}

}
