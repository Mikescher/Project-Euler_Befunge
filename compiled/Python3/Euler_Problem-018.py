#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABAC9VMtqw0AM/JUh7SnGRVp5X6GYfkhJevPVp3x/R17ogxjaErvCOCvh7OxoRguM0Y4QmUUm7QN/VeZRZbLjKbDUTQc59DF2x1ftPgsdv1iyWf194p+Y"
  + "9to/XC9cnD62Yn7FbeS4UsR5rfjLeL7J13BrRBpuqmtfbncSD80YMkq4e/MRj385rRZYRMlQ+boJxQ59E20RuwnbFqGjfJ63NfqTvI0P50s/fhOdEjd5m9w0y9xy0enp"
  + "JQhkcL5knVa1vkvsNbkb3wpRBHODicFutd4nSoEE5IxsEFI2pPwfuLV6e9nqwAMkaEIW1Ptt9lMM6k9IiAnFMAiKOLTZ/rgFOTgQrWVcZGdd2YG6I26kowg9eLdDxGCo"
  + "ihhQM6JCd7MZW6rqZKlvcxdvksyhpu7F13Efm5FdXgjagkKCrJB1LIiCkL3bFGLz8MFJ7meyK9XbzjkyWYgnpOpXGc1mujGuI1LNslDjCNdljorjVvMm+EmWOy1s6vB3"
  + "lpN0goAHAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<120 and y<16):
        return g[y*120 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<120 and y<16):
        g[y*120 + x]=v;
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
    gw(0,0,15)
    gw(2,0,gr(0,0)-1)
    gw(1,0,0)
    return 1
def _1():
    global t0
    gw(gr(1,0),gr(2,0)+1,((gr(gr(1,0)*3,gr(2,0)+1)-48)*10)+(gr((gr(1,0)*3)+1,gr(2,0)+1)-48))
    t0=gr(1,0)+1
    gw(1,0,gr(1,0)+1)
    t0=t0-gr(2,0)
    t0=t0-1
    return 2
def _2():
    global t0
    return (1)if((t0)!=0)else(3)
def _3():
    global t0
    t0=gr(2,0)
    gw(2,0,gr(2,0)-1)
    gw(1,0,0)

    return (1)if((t0)!=0)else(4)
def _4():
    global t0
    t0=gr(0,0)-2
    gw(1,0,gr(0,0)-2)
    gw(2,0,t0)
    return 5
def _5():
    global t0
    sa(gr(gr(1,0),gr(2,0)+1))
    sa(gr(gr(1,0),gr(2,0)+2))
    t0=gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2)

    return (6)if((gr(gr(1,0),gr(2,0)+2)-gr(gr(1,0)+1,gr(2,0)+2))>0)else(9)
def _6():
    global t0
    sa(sp()+sp());

    t0=sp()
    gw(gr(1,0),gr(2,0)+1,t0)
    t0=gr(1,0)
    gw(1,0,gr(1,0)-1)

    return (5)if((t0)!=0)else(7)
def _7():
    global t0
    global t1
    t0=gr(2,0)
    t1=gr(2,0)-1
    gw(2,0,gr(2,0)-1)
    gw(1,0,t1)

    return (5)if((t0)!=0)else(8)
def _8():
    print(gr(0,1),end=" ",flush=True)
    return 10
def _9():
    global t0
    sa(sp()-t0);
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9]
c=0
while c<10:
    c=m[c]()
