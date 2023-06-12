package uscs;

public class Computador {

	private String numSerie;
	private Teclado teclado;
	private Mouse mouse;
	private Monitor monitor;
	private Gabinete gabinete;

	public Computador(String n, Teclado T, Mouse M, Monitor Mon, Gabinete g) {
		
		numSerie = n;
		teclado = T;
		mouse = M;
		monitor = Mon;
		gabinete = g;
		
	}
	
	public Computador() {
		
	}
	
	
	public  void ImprimeComputador() {

		System.out.println("Computador: "+numSerie+ "\n"+
		
				"Numero de serie do teclado: "+ teclado.getNumSerie()+ "\n"+
				"fabricante do teclado: "+ teclado.getFabricante()+ "\n"+
				"Cor do teclado: "+ teclado.getCor()+ "\n"+
				
				"Numero de serie do mouse: "+ mouse.getNumSerie()+ "\n"+
				"fabricante do mouse: "+ mouse.getFabricante()+ "\n"+
				"Cor do mouse: "+ mouse.getCor()+ "\n"+

				"Numero de serie do monitor: "+ monitor.getNumSerie()+ "\n"+
				"fabricante do monitor: "+ monitor.getFabricante()+ "\n"+
				"Cor do monitor: "+ monitor.getCor()+ "\n"+

				"Numero de serie do gabinete: "+ gabinete.getNumSerie()+ "\n"+
				"fabricante do gabinete: "+ gabinete.getFabricante()+ "\n"+
				"Cor do gabinete: "+ gabinete.getCor()+ "\n"
				
				);
	}

	public String getNumSerie() {
		return numSerie;
	}

	public void setNumSerie(String numSerie) {
		this.numSerie = numSerie;
	}

	public Teclado getTeclado() {
		return teclado;
	}

	public void setTeclado(Teclado teclado) {
		this.teclado = teclado;
	}

	public Mouse getMouse() {
		return mouse;
	}

	public void setMouse(Mouse mouse) {
		this.mouse = mouse;
	}

	public Monitor getMonitor() {
		return monitor;
	}

	public void setMonitor(Monitor monitor) {
		this.monitor = monitor;
	}

	public Gabinete getGabinete() {
		return gabinete;
	}

	public void setGabinete(Gabinete gabinete) {
		this.gabinete = gabinete;
	}
	
}
