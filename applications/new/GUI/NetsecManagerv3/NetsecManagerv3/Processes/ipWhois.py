"""
IP Who.is modified code.
12.18.15 - (c) amabinal

"""
#imports
import cgitb
from ipwhois import IPWhois
from pprint import pprint
import socket
# import optparse
cgitb.enable()

# main logic: Search for IP (view details)
ipadd = input('Please enter the IP address: (enclosed with single quotes)')
who = socket.inet_aton(ipadd)#IPWhois(ipadd)
	# text to IP conversions
ipconv = socket.inet_ntoa(who)
	#who.is logic
obj = IPWhois(ipconv)
ipresult = obj.lookup_rdap(depth=1)
pprint(ipresult)
# switches

"""def Main():
	parser = optparse.OptionParser('usage %prog '+'-i <IP address>')
	parser.add_option('-i', dest='ipadd', type='string', help='Specify IP address')
	(options) = parser.parse_args()
	if (options.ipadd == None):
		print parser.usage
		exit(0)
	else:
		ipout = str(options.ipadd)

	for ipadd in ipout:
		ipWho(ipadd)




# main logic: View my IP
# main logic: Search for IP (with proxy)
# main logic: quit Modified IP Whois

if __name__ == '__main__':
	Main()
"""