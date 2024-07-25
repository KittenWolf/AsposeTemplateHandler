select 
	[bt], 
	[sn], 
	format([year2], 'MM.yyyy') as year2, 
	[fio], 
	format([datepr], 'dd.MM.yyyy') as datepr, 
	format([year1], 'yyyy') as year1
from [GasAnalyzers]