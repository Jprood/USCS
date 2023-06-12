package uscs;

public class Empregado {

	private String nome, endereco;
	private double valor_h;
	private int horas;
	
	public Empregado(String n, String e, double v, int h) {
		
		this.nome = n;
		this.endereco = e;
		this.valor_h = v;
		this.horas = h;
	}
	
	public Empregado() {
		
	}
	
	public void ImprimeEmpregado() {
		
		System.out.println(
				"Nome: "+ nome+ "\n"+
				"Endereço "+ endereco+ "\n"+
				"Valor das horas: "+ valor_h+ "\n"+
				"Horas trabalhadas: "+ horas+ "\n");
	}
	
	public double CalculaSalario() {
		
		return valor_h * horas;
		
	}
	
	public void ImprimeSalario() {
		
		System.out.println(
				"Nome: "+ nome+ "\n"+
				"Salario: "+ CalculaSalario()+ "\n");
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getEndereco() {
		return endereco;
	}

	public void setEndereco(String endereco) {
		this.endereco = endereco;
	}

	public double getValor_h() {
		return valor_h;
	}

	public void setValor_h(double valor_h) {
		this.valor_h = valor_h;
	}

	public double getHoras() {
		return horas;
	}

	public void setHoras(int horas) {
		this.horas = horas;
	}
}
