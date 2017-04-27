; Written in YASM/NASM on Arch Linux
; Assemble: yasm -f elf Addition.asm
; Link : ld -o test test.o
; Run: ./Addition
section    .data
    sum: dd 0		; initialize sum as a double word
section    .text
global main			; enter the program when main is called

main:
    mov ebp, esp	; for correct debugging
    mov eax,5		; load eax with 5
    add eax,6		; add 6 to eax
    mov [sum],eax	; set sum equal to what is in eax
    mov ebx,[sum]	; move sum to ebx
    
    mov eax,1		; call exit
    int 80h			; call kernel