package uscs;
public class TesteEmpregado {

	public static void main(String[] args) {
		
		Empregado e1 = new Empregado(1232, "Paulo Silva", "Gerente Financeiro", 15400.00);
		Empregado e2 = new Empregado();
		
		e2.setCod_imp(4567);
		e2.setNome("Ana Paula");
		e2.setCargo("Analista de Sistemas Senior");
		e2.setSalario(10700.00);
		
		e1.ImprimeEmpregados();
		e2.ImprimeEmpregados();
		
		e1.TotalEmpregados();
	}

}
