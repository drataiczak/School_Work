;TITLE Procedures.asm
%include "Along32.asm"
%include "Functions.asm"
;---------------------------------------------------------------------------------------------------------------------------------------------------
;
FibNum:
;
;---------------------------------------------------------------------------------------------------------------------------------------------------
    push edx		; Preserve edx

    add eax, ebx	; Add eax and ebx
    xchg ebx, eax	; Switch the values of eax and ebx
       
    pop edx		; Return edx
    ret			; Return to main program
    
;---------------------------------------------------------------------------------------------------------------------------------------------------
;  
BetterRandRange:
;
;---------------------------------------------------------------------------------------------------------------------------------------------------
    mov edx, ebx
    push ebx
    push edx
    mov ebx, eax
    call Random32
    mov edx, 0
    div ebx
    mov eax, edx
    
    pop edx
    pop ebx
    cmp eax, ebx
    jle end
    jg negate

negate:
    sub ebx, eax 
    mov eax, ebx
    mov ebx, edx

end:
    ret

;---------------------------------------------------------------------------------------------------------------------------------------------------
;
RandChar:
;
;---------------------------------------------------------------------------------------------------------------------------------------------------
RandString:
    push ecx
    mov ecx, eax
L1:  
    mov edx, 1
    mov eax, 1000
    call Delay
    mov eax, 26
    call Randomize
    Call RandomRange
    add eax, 65
    call WriteChar 
Loop L1
   
    mov eax, 0ah
    call WriteChar
    
    pop ecx
    ret

;---------------------------------------------------------------------------------------------------------------------------------------------------
;
WriteLineFeed:
;
;---------------------------------------------------------------------------------------------------------------------------------------------------
    push eax
    mov eax, 0ah
    call WriteChar
    pop eax

ret