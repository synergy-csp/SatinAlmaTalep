export default class Form1 extends Form.Designer {


	async DataGrid1_OnPropertyChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<any>) {
        let sum :number = 0;
        this.DataGrid1.rows.forEach(row=>{
            row.cells.forEach(cell=>{
                if(cell.name === "NumberBox3"){
                    sum += cell.value;
                }
            })
        });
        this.NumberBox1.value = sum;
	}
}