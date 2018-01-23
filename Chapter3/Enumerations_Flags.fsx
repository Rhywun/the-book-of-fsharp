open System

[<Flags>]
type DayOfWeekFlags =
| None = 0
| Sunday = 1
| Monday = 2
| Tuesday = 4
| Wednesday = 8
| Thursday = 16
| Friday = 32
| Saturday = 64

let weekend = DayOfWeekFlags.Saturday ||| DayOfWeekFlags.Sunday

int weekend

weekend.HasFlag DayOfWeekFlags.Sunday

enum<DayOfWeekFlags> 65