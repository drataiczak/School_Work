; Title: Encryption(2)
; Encrypts a message and decrypts it using a set encryption key

%include "Along32.asm"
%include "Functions.asm"

buffSz equ 129

section .bss
    eBuffer resb buffSz ; Reserve space for eBuffer
    
section .data
    msg0: db "Enter the string you wish to encrypt: ", 0
    msg1: db "Your encryption key is: ", 0
    msg2: db "Your encrypted message is: ", 0
    msg3: db "Your unencrypted message is: ", 0
    eLen: dd 0 
    kBuffer: db "ABXmv#7", 0 ; Encryption key
    kLen: equ $-kBuffer
    
section .text
global main
main:
    mov ebp, esp ;For correct debugging
    
    mov edx, msg1
    call WriteString ; Print prompt
    call EnterString ; Enter message
    mov edx, eBuffer ; Fill edx with eBuffer
    call WriteString ; Print eBuffer
    call Crlf
    mov [eLen], eax     ; Save the size of the message
    
    mov edx, msg0
    call WriteString ; Print prompt
    mov edx, kBuffer ; Fill edx with eBuffer
    call WriteString ; Print kBuffer
    call Crlf
    
    
    mov edx, msg2
    call WriteString ; Print prompt
    call Encrypt     ; Encrypt message
    mov edx, eBuffer ; Put encrypted message in edx
    call WriteString ; Print encrypted message
    call Crlf
    
    mov edx, msg3
    call WriteString ; Print prompt
    call Encrypt     ; Decrypt message
    mov edx, eBuffer ; Put decrypted message in edx
    call WriteString ; Print decrypted message
    
call exit
 
;---------------------------------------------------------;   
EnterString:
; Receives eBuffer and buffSz
; Reads string and stores into eBuffer
;---------------------------------------------------------;
push ebx
push edx
push ecx

    mov edx, eBuffer ; Buffer space
    mov ecx, buffSz  ; Buffer size
    call ReadString  ; Read from keyboard
    
pop ecx
pop edx
pop ebx
ret

Encrypt:
    xor esi, esi
    xor edi, edi
    mov ecx, [eLen] ; Move length of message to ecx
 
    L2:
        mov dl, byte[eBuffer + esi] ; Put individual byte of message into dl
        mov bl, byte[kBuffer + edi] ; Put individual byte of encryption key into bl
        xor dl, bl
        mov [eBuffer + esi], dl ; Put xor product into eBuffer
        
        inc edi ; Increment edi to get to next byte of kBuffer
        cmp edi, kLen - 1 ; Check if the message is longer than the key
    call Reset ; If message is longer than key, reset edi to start from beginning of key again
        
        inc esi ; Increment esi to go through entire message
        cmp esi, ecx ; Check if entire message has been encrypted
    jne L2 ; If entire message has not been encrypted, loop

ret

Reset:
    xor edi, edi ; Set edi to 0 to restart at beginning of kBuffer
ret