%include 'Functions.asm'

section .data
    array dd 40, 30, 20, 10
   
section .text
global main

main: 
    mov esi, array
    mov ecx, 4
    dec ecx
    mov eax, [array]
    call intLineFeed
    
L1:
    mov eax, [array + ecx * 4]
    call intLineFeed
    loop L1
    
    
    
    call exit