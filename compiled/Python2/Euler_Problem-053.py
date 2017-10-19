#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABACtUE0PwiAM/St0nRcIWhgHtxDiL2EeTLhy4qT/3fqBmy7zYHxJQ9PXPl5bBCIKBv4A8QV/0gump2x6k8ny21EuyxZHqVcdJbuBxPm+5qoUSLCxiTrV"
  + "J3JHKX1gbmhOjQYso1EDK9qdo3yr86yVQZ9XdwrD9FVuLpdDE+OMRd8K9JbS9vDp7+XJyhkTQ3sXNPrJwnK7h0R1J3RcaZkwFoQa/o2pZseIkMkN2vBVfJ4uRHxmpQyA"
  + "llxzXE5kWxapIa6IhbYwMAIAAA==")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<7):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<7):
        g[y*80 + x]=v;
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
    global t0
    gw(9,0,1)
    gw(9,1,1)
    gw(2,0,0)
    gw(3,0,1)
    t0=0
    return 1
def _1():
    sa(gr(3,0))

    return (3)if(gr(3,0)!=100)else(2)
def _2():
    sys.stdout.write(str(gr(2,0))+" ")
    sys.stdout.flush()

    sp();
    return 14
def _3():
    sa(sp()+1)

    sa(sr());
    gw(3,0,sp())
    sa(sp()/2);

    gw(4,0,sp())
    sa(gr(3,0)-(gr(4,0)*2))
    return 4
def _4():
    return (13)if(sp()!=0)else(5)
def _5():
    sa((1)if((gr(gr(4,0)+8,(0)if(gr(3,0)%2!=0)else(1))*2)>1000000)else(0))
    gw(gr(4,0)+9,gr(3,0)%2,gr(gr(4,0)+8,(0)if(gr(3,0)%2!=0)else(1))*2)
    return 6
def _6():
    global t0
    t0=(0)if((gr(gr(4,0)+9,(0)if(gr(3,0)%2!=0)else(1)))!=0)else(1)

    return (11)if((gr(gr(4,0)+8,(0)if(gr(3,0)%2!=0)else(1)))!=0)else(7)
def _7():
    sp();
    return 8
def _8():
    gw(2,0,gr(2,0)+((1)if(gr(3,0)-(gr(4,0)*2)!=0)else(0))+1)
    gw(gr(4,0)+9,gr(3,0)%2,0)
    sp();
    return 9
def _9():
    global t0
    t0=gr(4,0)-1
    gw(4,0,gr(4,0)-1)

    return (10)if((t0)!=0)else(1)
def _10():
    sa(sp()-(gr(3,0)-(gr(4,0)*2)))
    return 4
def _11():
    global t0
    return (7)if((t0)!=0)else(12)
def _12():
    return (8)if(sp()!=0)else(9)
def _13():
    sa((1)if((gr(gr(4,0)+9,(0)if(gr(3,0)%2!=0)else(1))+gr(gr(4,0)+8,(0)if(gr(3,0)%2!=0)else(1)))>1000000)else(0))
    gw(gr(4,0)+9,gr(3,0)%2,gr(gr(4,0)+9,(0)if(gr(3,0)%2!=0)else(1))+gr(gr(4,0)+8,(0)if(gr(3,0)%2!=0)else(1)))
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=0
while c<14:
    c=m[c]()
