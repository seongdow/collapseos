: COLS 80 ; : LINES 32 ;
: CURSOR! ( new old -- )
    DROP COLS /MOD 6 PC! ( y ) 5 PC! ( x ) ;
: CELL! ( c pos -- ) 0 CURSOR! 0 PC! ;

SYSVARS 0x70 + CONSTANT GRID_MEM
402 403 LOADR ( Grid )
390 LOAD  ( xcomp core high )
(entry) _
( Update LATEST )
PC ORG @ 8 + !
," BLK$ ' EFS@ BLK@* ! ' EFS! BLK!* ! GRID$ " EOT,
ORG @ 256 /MOD 2 PC! 2 PC!
H@ 256 /MOD 2 PC! 2 PC!
