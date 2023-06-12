package uscs;

public class Mouse {

private String numSerie, fabricante, cor;
	
	public Mouse(String s, String f, String c) {
		
		numSerie = s;
		fabricante = f;
		cor = c;
	}
	
	public Mouse() {
		
	}
	
	public void ImprimeMouse() {
		
		System.out.println("Número de série do mouse: "+ numSerie);
		System.out.println("Fabricante do mouse: "+ fabricante);
		System.out.println("Cor do mouse: "+ cor);
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
