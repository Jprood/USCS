package uscs;

public class Gabinete {

private String numSerie, fabricante, cor;
	
	public Gabinete(String s, String f, String c) {
		
		numSerie = s;
		fabricante = f;
		cor = c;
	}
	
	public Gabinete() {
		
	}
	
	public void ImprimeGabinete() {
		
		System.out.println("Número de série do gabinete: "+ numSerie);
		System.out.println("Fabricante do gabinete: "+ fabricante);
		System.out.println("Cor do gabinete: "+ cor);
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
