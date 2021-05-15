cargar(A) :- exists_file(A), consult(A).

factorial(0,1).
factorial(N,F) :-
	N>0,
	N1 is N-1,
	factorial(N1,F1),
	F is N * F1.
	
mcd(Num1, Num2, Num) :-
	Num1 > 0,
	Num2 > 0,
	Num3 is Num1 mod Num2,
	%write(Num3),
	mcdRec(Num2, Num3, Num4),
	Num is Num4.

mcdRec(Num2, 0, Num4) :-
	Num4 is Num2, !.	
mcdRec(Num2, Num3, Num4) :-
	Num5 is Num2 mod Num3,
	mcdRec(Num3, Num5, Num4).
	
	
	
	
	
	
	