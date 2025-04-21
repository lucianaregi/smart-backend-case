using System;

namespace questao1
{
    public class Resposta
    {
        // (a) Interface ou Classe Abstrata?

        // Interface: defino só o "contrato", sem implementação.
        public interface INotificavel
        {
            void Notificar(string mensagem);
        }

        // Classe abstrata: serve de base pra classes com lógica parcial ou padrão.
        public abstract class NotificadorBase
        {
            public abstract void Notificar(string mensagem);

            public void Log(string mensagem)
            {
                Console.WriteLine($"[LOG] {mensagem}");
            }
        }

        // Classe concreta que herda da abstrata
        public class EmailNotificador : NotificadorBase
        {
            public override void Notificar(string mensagem)
            {
                Console.WriteLine($"Enviando e-mail: {mensagem}");
            }
        }

        // (b) Herança ou Delegação?

        // Herança: quando é um tipo do outro. Ex: EmailNotificador é um NotificadorBase
        // Delegação: quando uma classe usa outra pra executar algo, sem acoplamento direto

        public class ServicoEmail
        {
            public void Enviar(string conteudo)
            {
                Console.WriteLine($"Email enviado: {conteudo}");
            }
        }

        public class Usuario
        {
            private ServicoEmail emailService = new ServicoEmail();

            public void Avisar()
            {
                emailService.Enviar("Bem-vinda!");
            }
        }
    }
}
