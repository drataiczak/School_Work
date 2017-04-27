%include "Procedures.asm"

section .text
global main
main:
     mov ebp, esp; for correct debugging
     mov eax, 10 ; Length of string
     mov ecx, 20
 
L2:
    call RandString
Loop L2

call exit
      
    