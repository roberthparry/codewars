using System;
using System.Collections.Generic;
using System.Linq;


class Kata
{
    public string driver(params string[] data)
    {
        DateTime dob = DateTime.Parse(data[3]);

        var surname = $"{data[2]}99999".Substring(0, 5).ToUpper();
        var decade = (dob.Year / 10) % 10;
        var month = dob.Month;
        if (data[4][0] == 'F') month += 50;
        var forenames = $"{data[0][0]}{data[1]}9".Substring(0, 2);

        return $"{surname}{decade}{month:00}{dob.Day:00}{dob.Year % 10}{forenames}9AA";
    }

}
