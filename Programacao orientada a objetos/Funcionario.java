
package funcionario;

public class Funcionario {
     String nome, email, telefone;
    int idade;
    
    public void imprime(){
        
        System.out.println(this.nome);
        System.out.println(this.email);
        System.out.println(this.telefone);
        System.out.println(this.idade);
    }
    
    public static void main(String[] args) {
        Funcionario x = new Funcionario ();
        x.nome ="João";
        x.email = "joao@gmail.com";
        x.idade = 20;
        x.telefone = "11944472735";
        x.imprime();
    
          }
    
}
