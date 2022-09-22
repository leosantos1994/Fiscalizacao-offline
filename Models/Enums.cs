using System.ComponentModel;

namespace Fiscalizacao.Models
{
    public enum Gestao
    {
        [Description("GESTÃO TÉCNICA")]
        GESTAO_TECNICA = 1,
        [Description("GESTÃO ASSISTENCIAL")]
        GESTAO_ASSISTENCIAL,
        [Description("GESTÃO DE ENSINO")]
        GESTAO_DE_ENSINO
    }

    public enum Funcao
    {
        [Description("Diretor Técnico")]
        Diretor_Tecnico,
        [Description("Assistente Técnico")]
        Assistente_Tecnico,
    }

    public enum SituacaoVinculo
    {
        [Description("Ativa/Aprovada")]
        Ativa = 1,
        [Description("Cancelada")]
        Cancelada,
        [Description("Expirada")]
        Expirada,
        [Description("Pendente")]
        Pendende,
        [Description("Recusada")]
        Recusada
    }

    public enum TipoContato
    {
        [Description("Telefone residencial")]
        Tel_Residencial = 1,
        [Description("Telefone comercial")]
        Tel_Comercial,
        [Description("Telefone celular pessoal")]
        Cel_Pessoal,
        [Description("Telefone celular profissional")]
        Cel_Profissional,
        [Description("E-mail pessoal")]
        Email_pessoal,
        [Description("E-mail profissional")]
        Email_profissional,
        [Description("Fax residencial")]
        Fax_residencial,
        [Description("Fax comercial")]
        Fax_comercial,
        [Description("Skype")]
        Skype,
        [Description("Recado")]
        Recado,
        [Description("Whats")]
        Whats,
    }

    public enum ModuloProcesso
    {
        Fiscalizacao,
        Juridico,
        Comissao,
        Secretaria,
        TED
    }
}
