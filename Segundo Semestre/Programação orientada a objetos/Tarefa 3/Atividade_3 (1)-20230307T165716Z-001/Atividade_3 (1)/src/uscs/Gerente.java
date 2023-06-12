package uscs;

public class Gerente extends Empregado {

	private double bonus;
	private String nome_s;
	
	public Gerente(String nome, String endereco, double valor_h, int horas, double b, String s) {
		
		super(nome, endereco, valor_h, horas);
		this.bonus = b;
		this.nome_s = s;
	}
	
	public Gerente() {
		
	}
	
	public double CalculaSalario() {
		
		return super.CalculaSalario() + bonus;
	}
	
	public void ImprimeGerente() {
		
		super.ImprimeEmpregado();
		System.out.println(
				"Bonus: "+ bonus+ "\n"+
			    "Nome da secretaria: "+ nome_s+ "\n");
	}
	
	public void ImprimeSalario() {
		
		System.out.println(
				"Salario com bonus: "+ CalculaSalario());
	}

	public double getBonus() {
		return bonus;
	}

	public void setBonus(double bonus) {
		this.bonus = bonus;
	}

	public String getNome_s() {
		return nome_s;
	}

	public void setNome_s(String nome_s) {
		this.nome_s = nome_s;
	}
}
