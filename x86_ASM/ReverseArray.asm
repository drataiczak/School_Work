%include 'Functions.asm'

section .data
    array dd 3, 12, 2, 3, 4
    len equ $-array

section .text
global main

main:
    mov ebp, esp; for correct debugging
    mov ecx, len / 4
    mov esi, array  
    mov eax, [array]
    call intLineFeed
    cld
    lodsd
    
    mov edx, eax
    dec ecx
    
 L1:
     lodsd
     call intLineFeed
     loop L1
     
    
    call exit