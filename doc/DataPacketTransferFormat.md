# Ronma Data Packet Transfer Format

## Format

[length(Hex)]\0[service]\0[command]\0[args]\0\0\0

## Sample

If you want to send a command to the memory service to remember something:
> 36\0memory\0store\0alarm:call Jeff today 6:00 pm. \0\0\0
