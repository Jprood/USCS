
package aluno;

public class Aluno {
    String nome, cpf;
    float n1, n2, n3; 
    char sexo;
    int codmat;
    
    public void imprimeAluno () {
        System.out.println(this.nome);
        System.out.println(this.cpf);
        System.out.println(this.codmat);
        System.out.println();
        
    }
    
    public void imprimeSexo () {
        
        if(this.sexo == 'M'){
            
            System.out.println("Masculino");
            System.out.println(this.nome);
        }else{
            
            System.out.println("Feminino");
            System.out.println(this.nome);
        }
    }
    
    public void MediaAluno () {
        double media;
        
        media = (this.n1*1)+(this.n2)+(this.n3)/3;
        
        if(media >= 6.0){
            
            System.out.println("Aprovado");
        }else{
            System.out.println("Reprovado");
        }
    }
    
    public static void main(String[] args) {
    Aluno x = new Aluno ();
    
    x.nome ="João";
    x.cpf = "51215583234";
    x.codmat = 1234;
    x.sexo = 'M';
    x.n1 = 8;
    x.n2 = 7;
    x.n3 = 10;
    x.imprimeAluno();
    x.imprimeSexo();
    x.MediaAluno();
    
    }
    
}
