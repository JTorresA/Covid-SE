
cargar(A) :- exists_file(A), consult(A).
sintomas(P1,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,"Fiebre") :-
	P1='si'.
sintomas(P1,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,"No Fiebre") :-
	P1='no'.	
	
/*
sintomas(P1,_,P3,P4,P5,_,P7,P8,_,_,_,P12,P13,P14,P15,P16,P17,P18,"Alergias") :-
	P1='no', P3='no', P4='no', P5='si',	P7='no', P8='no',
	P12='no', P13='no', P14='no', P15='no', P16='si', P17='si', P18='si'),!.*/
/*	
sintomas(P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13,P14,P15,P16,P17,P18,"Alergias") :-
    P1='no', P3='no', P4='no', P5='si',	P7='no', P8='no',
	P12='no', P13='no', P14='no', P15='no',
	
	(P2='si'; P6='si');
    (P9='si'; P10='si'; P11='si');    
    (P16='si'; P17='si'; P18='si'),!.
*/

/*
sintomas(P1,P2,P3,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,"Covid-19") :-
    P1='si',
	(P2='si';
	P3='si').
    
sintomas(P1,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,"Nada") :-
    P1='no'.
sintomas(_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,"Sin sintomas") :-
    .
*/
	
	