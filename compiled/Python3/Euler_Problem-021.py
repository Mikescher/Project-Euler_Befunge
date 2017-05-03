#!/usr/bin/env python3

# transpiled with BefunCompile v1.1.0 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABADt2slqwzAQgOFXcb1cIi8jxzpEBNEHCUkPBV110skPnwmmgdCWlDaB0PzfRaPRgpDxnJQLPJIKAAAAAAAAAAAAAAAAAIB/4OqDuZA/gvPcfIq2d3qg"
  + "9+RC+V5OK28lObdaiSSRGGzn/ajhbhz8HDSMu6baH/xaklkv49qt8/XtcQOz/zKdjB2i2ChjszT8IreX6/qin6zIxT0H++3a/X2O9NSC1ifbnYrTRlLQymQlNkszWBMn"
  + "SdOSm845J6nQGU5iV+WDRjr09rKEfVl0Rdm2reZ650xLTfuDOcnYWa+l6Kcrtp9D/bLGRJl0lygbatrvvPZc3iM4ApHVms+QMwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
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
    sa(gr(0,0)-1)
    gw(2,0,gr(0,0)-1)
    return 1
def _1():
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),2))

    sa(sr());

    return (2)if(sp()!=0)else(16)
def _2():
    global t0
    global t1
    sa(sr());
    t0=gr(2,0)
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))

    t1=sp()

    return (15)if((t1)!=0)else(3)
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

    return (14)if(sp()!=0)else(7)
def _7():
    gw(0,1,0)
    gw(2,0,gr(0,0)-1)
    gw(9,0,0)
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1))
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1))
    sp();
    sp();
    return 8
def _8():
    return (9)if(gr(2,0)!=gr(5,0))else(12)
def _9():
    sa(gr(2,0))
    gw(2,0,gr(2,0)-1)

    return (10)if(sp()!=0)else(11)
def _10():
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1))
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1))
    return 8
def _11():
    print(gr(9,0),end="",flush=True)
    return 17
def _12():
    return (9)if(gr(2,0)<=gr(4,0))else(13)
def _13():
    print(gr(2,0),end="",flush=True)
    print(" - ",end="",flush=True)
    print(gr(4,0),end="",flush=True)
    print(chr(10),end="",flush=True)
    gw(9,0,gr(9,0)+gr(2,0)+gr(4,0))
    return 9
def _14():
    sa(sp()-1);

    sa(sr());
    sa(sr());
    gw(2,0,sp())
    return 1
def _15():
    sa(sp()-1);

    sa(sr());
    return 4
def _16():
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,1)
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16]
c=0
while c<17:
    c=m[c]()
