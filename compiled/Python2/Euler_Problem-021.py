#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADt2slqwzAQgOFXcb1cIi8jxzpEBNEHCUkPBV110skPnwmmgdCWlDaB0PzfRaPRgpDxnJQLPJIKAAAAAAAAAAAAAAAAAIB/4OqDuZA/gvPcfIq2d3qg"
  + "9+RC+V5OK28lObdaiSSRGGzn/ajhbhz8HDSMu6baH/xaklkv49qt8/XtcQOz/zKdjB2i2ChjszT8IreX6/qin6zIxT0H++3a/X2O9NSC1ifbnYrTRlLQymQlNkszWBMn"
  + "SdOSm845J6nQGU5iV+WDRjr09rKEfVl0Rdm2reZ650xLTfuDOcnYWa+l6Kcrtp9D/bLGRJl0lygbatrvvPZc3iM4ApHVms+QMwAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<400 and y<33):
        return g[y*400 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<400 and y<33):
        g[y*400 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(1,0,400)
    gw(0,0,10000)
    sa(gr(0,0)-1)
    sa(0)
    sa((gr(0,0)-1)/2)
    sa((gr(0,0)-1)/2)
    gw(2,0,gr(0,0)-1)
    return 1
def _1():
    return (2)if(sp()!=0)else(15)
def _2():
    global t0
    global t1
    t0=gr(2,0)
    sa(sr());
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))

    t1=sp()

    return (14)if((t1)!=0)else(3)
def _3():
    sa(sr());
    gw(3,0,sp())
    sa(sp()+sp());

    sa(gr(3,0)-1)
    sa(gr(3,0)-1)
    return 4
def _4():
    return (2)if(sp()!=0)else(5)
def _5():
    sp();
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,sp())
    return 6
def _6():
    sa(sr());

    return (13)if(sp()!=0)else(7)
def _7():
    gw(0,1,0)
    gw(2,0,gr(0,0)-1)
    gw(9,0,0)
    sp();
    sp();
    return 8
def _8():
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1))
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1))

    return (9)if((gr(2,0)-gr(5,0))!=0)else(11)
def _9():
    global t2
    t2=gr(2,0)
    gw(2,0,gr(2,0)-1)

    return (8)if((t2)!=0)else(10)
def _10():
    sys.stdout.write(str(gr(9,0))+" ")
    sys.stdout.flush()
    return 16
def _11():
    return (12)if(gr(2,0)>gr(4,0))else(9)
def _12():
    sys.stdout.write(str(gr(2,0))+" ")
    sys.stdout.flush()

    sys.stdout.write(" - ")
    sys.stdout.flush()

    sys.stdout.write(str(gr(4,0))+" ")
    sys.stdout.flush()

    sys.stdout.write(chr(10))
    sys.stdout.flush()

    gw(9,0,gr(9,0)+gr(2,0)+gr(4,0))
    return 9
def _13():
    sa(sp()-1)

    sa(sr());
    sa(sr());
    gw(2,0,sp())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/2);

    sa(sr());
    return 1
def _14():
    sa(sp()-1)

    sa(sr());
    return 4
def _15():
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,1)
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15]
c=0
while c<16:
    c=m[c]()
