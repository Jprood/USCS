package uscs;

public class Teclado {

	private String numSerie, fabricante, cor;
	
	public Teclado(String s, String f, String c) {
		
		numSerie = s;
		fabricante = f;
		cor = c;
	}
	
	public Teclado() {
		
	}
	
	public void ImprimeTeclado() {
		
		System.out.println("Número de série do teclado: "+ numSerie);
		System.out.println("Fabricante do teclado: "+ fabricante);
		System.out.println("Cor do teclado: "+ cor);
	}

	public String getNumSerie() {
		return numSerie;
	}

	public void setNumSerie(String numSerie) {
		this.numSerie = numSerie;
	}

	public String getFabricante() {
		return fabricante;
	}

	public void setFabricante(String fabricante) {
		this.fabricante = fabricante;
	}

	public String getCor() {
		return cor;
	}

	public void setCor(String cor) {
		this.cor = cor;
	}
	
}
