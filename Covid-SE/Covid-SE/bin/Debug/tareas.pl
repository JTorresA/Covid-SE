cargar(A) :- exists_file(A), consult(A).	

% Utiliza la inferencia para determinar el resultado, basandose en la aparicion de
% los sintomas que manifiesta padecer el paciente al contestar el cuestionario.
% Utiliza los operadores and (,) y el or (;) junto con los parentesis para poder 
% diferenciar o hacer mas visible en que grupos son aplicados.
	
% INICIA COINCIDENCIAS PARA SINTOMAS DE ALERGIAS
sintomas(P1,_,P3,P4,P5,_,P7,P8,_,_,_,P12,P13,P14,P15,P16,P17,P18,"Alergias") :-
	P1='no', P3='no', P4='no', P5='si',	P7='no', P8='no',
	P12='no', P13='no', P14='no', P15='no', P16='si', P17='si', P18='si'.

sintomas(P1,_,P3,P4,P5,_,P7,P8,_,_,_,P12,P13,P14,P15,P16,P17,P18,"Alergias") :-
	P1='no', P3='no', P4='no', P5='si',	P7='no', P8='no',
	P12='no', P13='no', P14='no', P15='no', (P16='si'; P17='si'; P18='si').

sintomas(P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13,P14,P15,P16,P17,P18,"Alergias") :-
    P1='no', P3='no', P4='no', P5='si',	P7='no', P8='no',
	P12='no', P13='no', P14='no', P15='no',
	((P2='si'; P6='si');
    (P9='si'; P10='si'; P11='si');    
    (P16='si'; P17='si'; P18='si')).

sintomas(_,_,_,_,_,_,_,_,_,_,_,_,_,_,P15,P16,P17,P18,"Alergias") :-
    P15='no', (P16='si'; P17='si'; P18='si').	
% TERMINA COINCIDENCIAS PARA SINTOMAS DE ALERGIAS	

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% INICIA COINCIDENCIAS PARA SINTOMAS DE RESFRIADO
sintomas(P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13,P14,P15,P16,P17,P18,"Resfriado") :-
    P1='no', P3='si', P4='no', P5='no',	P6='no', P7='no', P8='no', P9='no',
	P10='no', P11='no', P12='no', P13='no', P15='no';
	(P2='si';P14='si');    
    (P16='si'; P17='si'; P18='si').
% TERMINA COINCIDENCIAS PARA SINTOMAS DE RESFRIADO

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% INICIA COINCIDENCIAS PARA SINTOMAS DE INFLUENZA
sintomas(P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13,P14,P15,P16,P17,P18,"Influenza") :-
	P5='no', P9='no', P10='no',
	(P1='si'; P2='si'; P3='si'; P4='si'; P6='si'; P11='si'; P12='si'; P13='si'; P14='si'; P15='si');
    (P7='si'; P8='si'; P16='si'; P17='si'; P18='si').
% TERMINA COINCIDENCIAS PARA SINTOMAS DE INFLUENZA

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% INICIA COINCIDENCIAS PARA SINTOMAS DE COVID

sintomas(P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13,P14,P15,P16,P17,P18,"Covid-19") :-
	P17='no', P18='no',
	(P1='si'; P2='si'; P4='si'; P5='si'; P7='si'; P8='si'; P11='si'; P12='si'; P13='si'; P14='si');
    (P3='si'; P6='si'; P9='si'; P10='si'; P15='si'; P16='si'; P17='si'; P18='si'). 
% TERMINA COINCIDENCIAS PARA SINTOMAS DE COVID

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% TODO NO
sintomas(P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13,P14,P15,P16,P17,P18,"No tiene ningun sintoma, sientase tranquilo.") :- 
	P1='no', P2='no', P3='no', P4='no', P5='no', P6='no', P7='no', P8='no',
	P9='no', P10='no', P11='no', P12='no', P13='no', P14='no', P15='no', P16='no', P17='no', P18='no'.
% TODO SI
sintomas(P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13,P14,P15,P16,P17,P18,"Usted tiene todo, vaya a internarse.") :- 
	P1='si', P2='si', P3='si', P4='si', P5='si', P6='si', P7='si', P8='si', P9='si', 
	P10='si', P11='si', P12='si', P13='si', P14='si', P15='si', P16='si', P17='si', P18='si'.
% INICIA POR DEFECTO
sintomas(_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,"Sus síntomas coinciden con varias enfermedades, acuda a su médico.") :- .	