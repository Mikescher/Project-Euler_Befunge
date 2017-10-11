#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADtkc8KgzAMxl9FCl4Mzq9qVxCRPYmnQa49efLhF5ljRdmYjv055Lsk/dL0l7ZD8jths/a0KFrRila0ohWtaEUr+iNou6flz9Q5d/RZlgHBlMYiJGWF"
  + "0A3fQG+yp//hGgFOxqvBNpfFFMGpqQ1d08ISG5i8mSt24TswUTIkQ7s4fGU80MioA9mCYSUjm86JHB7ZMlBUSMk5mbuQ0LR9O+aZZOZscoZnQAzZxLduf+/2bYCXK1ck"
  + "i+rFCZ+pq8CHU2x4eR4Sxmpr/z4t0gVqKcfndA0AAA==")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<123 and y<28):
        return g[y*123 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<123 and y<28):
        g[y*123 + x]=v;
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
    gw(0,0,1050)
    gw(1,0,50)
    gw(3,0,2)
    return 1
def _1():
    gw(4,0,gr(0,0))
    gw(5,0,0)
    return 2
def _2():
    global t0
    global t1
    gw(4,0,gr(4,0)-1)
    t0=gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48
    t1=(gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48)+(gr((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1)-48)+gr(5,0)
    gw(5,0,td((gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48)+(gr((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1)-48)+gr(5,0),10))
    t1=tm(t1,10)
    t1=t1+48
    gw((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1,t1)
    t0=t0+48
    gw((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1,t0)
    return 3
def _3():
    return (2)if((gr(4,0))!=0)else(4)
def _4():
    gw(3,0,gr(3,0)+1)
    gw(7,0,0)
    return 5
def _5():
    return (7)if(gr((tm(gr(7,0),gr(1,0)))+52,(td(gr(7,0),gr(1,0)))+1)!=48)else(6)
def _6():
    gw(7,0,gr(7,0)+1)
    return 5
def _7():
    return (1)if(gr(0,0)-gr(7,0)!=1000)else(8)
def _8():
    sys.stdout.write(str(gr(3,0))+" ")
    sys.stdout.flush()
    return 9
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()
