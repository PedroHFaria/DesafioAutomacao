jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "BuscaCep.feature",
      "Feature": {
        "Name": "Busca CEP",
        "Description": "Eu como usuário\r\ndesejo buscar o CEP no site dos correios\r\npara visualizar o resultado da busca",
        "FeatureElements": [
          {
            "Name": "Buscar cep que nao existe",
            "Slug": "buscar-cep-que-nao-existe",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "que acesse o site correios",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "desejo buscar um cep inexistente",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "o site deve retornar que endereco nao existe",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "voltar para a tela inicial",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Automatizado"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          },
          {
            "Name": "Buscar cep correto",
            "Slug": "buscar-cep-correto",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "que acesse o site correios",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "desejo buscar um cep correto",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "o site deve retornar o endereco Rua Quinze de Novembro, São Paulo/SP com sucesso",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "voltar para a tela inicial",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Automatizado"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false,
          "WasProvided": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false,
        "WasProvided": false
      }
    },
    {
      "RelativeFolder": "PesquisarCodigoRastreamento.feature",
      "Feature": {
        "Name": "Busca Codigo de Rastreamento",
        "Description": "Eu como usuário\r\ndesejo buscar o código de rastreamento no site dos correios\r\npara acompanhar o envio do objeto",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "codigo de rastreamento"
                  ],
                  "DataRows": [
                    [
                      "SS987654321BR",
                      {
                        "WasExecuted": false,
                        "WasSuccessful": false,
                        "WasProvided": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Buscar codigo de rastreamento que nao existe",
            "Slug": "buscar-codigo-de-rastreamento-que-nao-existe",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "que acesse o site correios",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "desejar busca o <codigo de rastreamento>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "o site deve retornar que codigo de rastreamento nao existe",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "fechar o navegador",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Automatizado"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false,
              "WasProvided": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false,
          "WasProvided": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false,
        "WasProvided": false
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@Automatizado",
        "Total": 3,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 3
      }
    ],
    "Folders": [
      {
        "Folder": "BuscaCep.feature",
        "Total": 2,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 2
      },
      {
        "Folder": "PesquisarCodigoRastreamento.feature",
        "Total": 1,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 1
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "BuscaCep.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Folder": "PesquisarCodigoRastreamento.feature",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 3,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 3
    },
    "Features": {
      "Total": 2,
      "Passing": 0,
      "Failing": 0,
      "Inconclusive": 2
    }
  },
  "Configuration": {
    "SutName": "Cactus",
    "GeneratedOn": "7 março 2023 17:12:06"
  }
});