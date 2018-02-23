# Correlation Data Miner

## Description
*Correlation Data Miner* combs through complex and dynamic multi-variable data, such as data obtained from human behaviour. It determines the intervals in which all required specifics are met among each data set. For example, *Correlation Data Miner* can output values within variable C when variables A and B independently meet certain criteria, as well as determine the frequency of said scenario in intervals. Data filtering in this manner can aid in further detailed statistical analyses in the field of research psychology.

## Application
Human movement data collected using *Correlation Map Analysis* (Adriano et al., 2012) provides motion information for two talkers engaging in a conversation and the similarity or the 'correlation' of the two talkers' motion. *Correlation Data Miner* can select values based on specific conditions for more specified analyses (e.g., How similar or 'correlated' two talkers' motion is only when both their motions exceed a certain value). *Correlation Data Miner* was used in this manner, in the peer-reviewed article [***Movement Coordination during Conversation***](http://journals.plos.org/plosone/article?id=10.1371/journal.pone.0105036), authored by [**Nida Latif**](https://nlatif.wordpress.com/) and published in 2014.

## Development
*Correlation Data Miner* is a *Windows Forms Application* developed entirely in *C#* that allows a user to browse their local drive for three files, representing Correlation Signal, Signal 1, and Signal 2 data. The user is also asked to set the requirement for the top percentile of values from each file. After reading each file, *Correlation Data Miner* flags values that meet the stated requirements and calculates the intervals containing consecutive values that meet all three requirements. With the values of each intervals collected, *Correlation Data Miner* calculates the average correlation, signal one and signal two data values for each interval. *Correlation Data Miner* then uses the Microsoft Excel 16.0 Object Library to construct an Excel worksheet programmatically, containing the results of the analyses. If the local system does not have Microsoft Excel installed in it, the output will be in regular text format.

### Built With
* _Programming Language_: **C#** 
* _IDE_: **Visual Studio 2017**

### Author
[**Abdul Sadiq**](https://github.com/LedMetal)

### License
This project is licensed under the MIT License - see the LICENSE.md file for details

### Acknowledgments
[**Nida Latif**](https://nlatif.wordpress.com/) - Thank you for allowing my inclusion in your research!
