package uscs;
public class Empregado {

	private int cod_imp;
	private static int i = 0;
	private String nome, cargo;
	private double salario;
	
	public Empregado(){
		
		i++;
	}
	
	public Empregado(int cod, String n, String c, double s) {
		
		cod_imp = cod;
		salario = s;
		nome = n;
		cargo = c;
		i++;
	}
	
	public void ImprimeEmpregados() {
		
		System.out.println("codigo do empregado: "+ cod_imp);
		System.out.println("Nome do empregado: "+ nome);
		System.out.println("Cargo do empregado: "+ cargo);
		System.out.println("salário do empregado: "+ salario);
	}
	
	public void TotalEmpregados(){
		
		System.out.println("Total de empregados: "+ i);
		
	}

	public int getCod_imp() {
		return cod_imp;
	}

	public void setCod_imp(int cod_imp) {
		this.cod_imp = cod_imp;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getCargo() {
		return cargo;
	}

	public void setCargo(String cargo) {
		this.cargo = cargo;
	}

	public double getSalario() {
		return salario;
	}

	public void setSalario(double salario) {
		this.salario = salario;
	}
	
}
