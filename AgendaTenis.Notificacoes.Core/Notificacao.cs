using AgendaTenis.Notificacoes.Core.Enums;

namespace AgendaTenis.Notificacoes.Core;

public class Notificacao
{
    public string Mensagem { get; set; }
    public TipoNotificacaoEnum Tipo { get; set; }
}
