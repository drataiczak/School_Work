%include "Functions.asm"
%include "Procedures.asm"

section .data
    maxVal dd 0
section .text
global main    
main:
    mov ebp, esp; for correct debugging
    mov eax, 100
    mov ebx, -300
    mov ecx, 50
    neg ebx
    add eax, ebx
    mov ebx, 100
    mov [maxVal], eax
 
L1:  
    mov eax, 1000
    call Delay
    call Randomize
    mov eax, [maxVal]
    call BetterRandRange  
    call intLineFeed
    loop L1
    call exit
   