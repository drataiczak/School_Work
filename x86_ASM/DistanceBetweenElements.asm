%include 'Functions.asm'

section .data
    array dd 0, 2, 5, 9, 10
    len equ $-array
   
section .text
global main
main:
    mov ebp, esp; for correct debugging
    mov esi, array
    mov ecx, len/4
    mov ebx, 0
    cld
    lodsd
    mov edx, eax
    dec ecx
    
L1:
    lodsd
    add ebx, eax
    sub ebx, edx
    mov edx, eax
    loop L1 
    
    mov eax, ebx
    call intLineFeed
    call exit
   