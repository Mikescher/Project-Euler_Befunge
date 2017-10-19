#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABACtkcFqxCAQhl8lNU0pimXmNyREgvRBQnopzNWTpzx8xyULuwS2bNoRRceZz3/GEihAx2VpzlsJ/C+c4Q+5t5ZgU4wkhozvR+sWyjGWU6gtes68ODv2"
  + "XnHCzfw8pDSvJ7KOlkDIzDqBbPBmLLuATBPyU9UVkGMBZUxOML04ryfuRnXNqd2DqG1K3e/K01FNSSpE2KmgAOm7u9vtGsVNSoAsUmO93w6cX2pWtPk2nebRWsW0V64+"
  + "q9zITpsxDO4huXS2V4ogaIHrF68q0Du25h0XZ0aoHQlK5EdfddOFNVWKuibIx+fuuwuefwDyEoFQYAMAAA==")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<72 and y<12):
        return g[y*72 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<72 and y<12):
        g[y*72 + x]=v;
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
    gw(12,0,gr(12,0)-20)
    gw(12,1,gr(12,1)-20)
    sa(11)
    sa(11)
    return 1
def _1():
    return (2)if(sp()!=0)else(3)
def _2():
    sa(sr());
    sa(sr());
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48)

    sa(sp()+28)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48)

    sa(sp()+28)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1)

    sa(sr());
    return 1
def _3():
    gw(0,2,2)
    gw(1,2,1)
    gw(2,2,1)
    gw(3,2,1901)
    gw(9,2,0)
    sp();
    return 4
def _4():
    gw(9,2,((0)if((gr(0,2)%7)+(gr(1,2)-1)!=0)else(1))+gr(9,2))
    gw(0,2,gr(0,2)+1)
    gw(1,2,gr(1,2)+1)

    return (5)if((gr(3,2)%4)!=0)else(11)
def _5():
    sa(gr(gr(2,2),0)-(gr(1,2)-1))
    return 6
def _6():
    return (9)if(sp()!=0)else(7)
def _7():
    global t0
    gw(1,2,1)
    t0=gr(2,2)-12
    gw(2,2,gr(2,2)+1)

    return (9)if((t0)!=0)else(8)
def _8():
    gw(2,2,1)
    gw(3,2,gr(3,2)+1)
    return 9
def _9():
    return (4)if(gr(3,2)!=2001)else(10)
def _10():
    sys.stdout.write(str(gr(9,2))+" ")
    sys.stdout.flush()
    return 14
def _11():
    return (12)if((gr(3,2)%100)!=0)else(13)
def _12():
    sa(gr(gr(2,2),1)-(gr(1,2)-1))
    return 6
def _13():
    return (5)if((gr(3,2)%400)!=0)else(12)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=0
while c<14:
    c=m[c]()
