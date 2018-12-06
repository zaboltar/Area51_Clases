using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TODO_RESEARCH : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


// pedirle a Hilble: cambio de camaras con 2 camaras + enemy AI + raycast to player to berserk


// beta.notes. Veremos procesos asyncronos, unity lo procesa con coroutines. 
// los procesos suelen stackearse en el main thread
// los procesos van entrando de acuerdo a los llamados (stack) en tiempo de ejecuciòn
// se ejecutan 1 a 1 siguiendo la lìnea del proceso, hay procesos q se agregan en el desarrollo
// un hilo toma como suyo un nucleo especìfico; ejm; un sist operativo.
// algunos procesos se almacenan en memoria, otros corren mediante el RAM
// ver sistema de procesamiento de datos
// es posible correr dos hilos en simultaneo
// los procesos pueden llegarse a no ejecutarse o atorarse, atràs, sin pasar
// un vez q se separan los hilos, son processos separados.
// en alguna parte del RAm se almacena una referencia al hilo, el canal por donde ingresan los procesos (y los procesos mismos?)
// se puede generar otro hilo, supervisarlo y "observarlo" pero el modelo de observer no es exactamente asì
// los procesos async no sabes cuando van a terminar y muchas mas x considerar, latencia...?? wtf
// threading tiene varios elementos, como semaforos. 
// los procesos asynchronos no solo se trata del threading. El threading por su naturaleza es asynchrono. depende de controladores separados.
// unity tiene varias cosas en contra de los threadings. a unity no le gustan los destiempos. por ello restringe su uso, porq 
// accedes a sus librerias de mala manera. 
// threading no solo los genera, sino q cuando lo pides, lo almacenas en memoria para no perder la referencia
// se limita y ajustan los parametros, pero no se sabe el tiempo cuando sera llamado el proceso, corren asynchronamente
// a-syn-chronos /greek/ negacion-junto-tiempo => fuera de tiempo, a destiempo, syncopado.
// no todo proceso asynchrono es un threading, pero todo threading por naturaleza es asynchrono.
// simula q es otro thread, pero esta tomando una distancia temporal...en unity, no pierde referencia a la info procesada, la guarda
// se puede parametrar el tiempo mediante frames o segundos ocurridos. 
// hay q hacer las corutinas pensando en q por ej los while tengan un yield return, para q no estanque o congestione el resto de procesos
// una corutina puede albergar funciones de otra corutina.
// asynchronos en threading es distinto en unity...considerar eso. 
// en unity hay procesos, q si tienen instruccion de espera, se stackean en los procesos para remandarse y asì se emula un thread alterno
// un mal uso de corutinas puede hacer que unity, el estado y la trascendencia del ser exploten.
// para usar coroutines tiene q heredar de monobehaviour

