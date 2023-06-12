package uscs;

public class Monitor {

private String numSerie, fabricante, cor;
	
	public Monitor(String s, String f, String c) {
		
		numSerie = s;
		fabricante = f;
		cor = c;
	}
	
	public Monitor() {
		
	}
	
	public void ImprimeMonitor() {
		
		System.out.println("Número de série do monitor: "+ numSerie);
		System.out.println("Fabricante do monitor: "+ fabricante);
		System.out.println("Cor do monitor: "+ cor);
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
