Public Class Form1
    Public cstmr As New customer
    Public supp As New Supplier
    Public ord As New Order
    Public st As New stock
    Public itm As New item
    'customer codes///////////////////////////////////////////////////////
    Private Sub clear()
        txtCname.Text = ""
        txtCadd.Text = ""
        txtCcont.Text = ""
        txtSname.Text = ""
        txtScont.Text = ""
        txtSitemname.Text = ""
        txtSitemDesc.Text = ""
        txtSttotalprice.Text = ""
        txtstdesc.Text = ""
        txtstitemname.Text = ""
        txtstqty.Text = ""
        txtIitemname.Text = ""
        txtiitemdesc.Text = ""
        txtiitemprice.Text = ""
        cmbStsid.Text = ""
        ComboBox1.Text = ""
        cmbCustname.Text = ""
        txtitemquantity.Text = ""
        ComboBox2.Text = ""
  
    End Sub
    Private Sub BtnCcreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCcreate.Click
        cstmr.cus_names = txtCname.Text
        cstmr.cus_adds = txtCadd.Text
        cstmr.cus_phos = txtCcont.Text
     
            Try
                cstmr.customer_add()
            Catch ex As Exception
                MsgBox("error")
            End Try

        cstmr.ShowTable(custdatagrid)
        cmbCustname.Items.Clear()
        ord.getcustnamesz(cmbCustname)


        clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        supp.ShowTable(supplierdatagrid)
        cstmr.ShowTable(custdatagrid)
        ord.getcustnamesz(cmbCustname)
        ord.GetItemnamesz(ComboBox1)
        st.combo(cmbStsid)
        st.item(ComboBox2)
        st.ShowTable(stockdatagrid)
        itm.ShowTable(itemdatagrid)
        Timer1.Enabled = True
    End Sub


    Private Sub BtnCupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCupdate.Click
        cstmr.cus_names = txtCname.Text
        cstmr.cus_adds = txtCadd.Text
        cstmr.cus_phos = txtCcont.Text
        Try
            cstmr.customer_update()
        Catch ex As Exception
            MsgBox("error")
        End Try
        cstmr.ShowTable(custdatagrid)

        clear()
    End Sub

    Private Sub BtnCdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCdel.Click
        cstmr.cus_ids.ToString()
        cstmr.customer_delete()
        cstmr.ShowTable(custdatagrid)
        clear()
    End Sub

    Private Sub custdatagrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles custdatagrid.CellContentClick
        cstmr.cus_ids = custdatagrid(0, custdatagrid.CurrentRow.Index).Value
        txtCname.Text = custdatagrid(1, custdatagrid.CurrentRow.Index).Value
        txtCadd.Text = custdatagrid(2, custdatagrid.CurrentRow.Index).Value
        txtCcont.Text = custdatagrid(3, custdatagrid.CurrentRow.Index).Value
    End Sub


    'supplier codes//////////////////////////////////////////////////////

    Private Sub btnScreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScreate.Click
        supp.s_names = txtSname.Text
        supp.s_phones = txtScont.Text
        supp.s_inames = txtSitemname.Text
        supp.s_descs = txtSitemDesc.Text
        Try
            supp.supplier_add()
        Catch ex As Exception
            MsgBox("error")
        End Try
        supp.ShowTable(supplierdatagrid)
        st.combo(cmbStsid)
        cmbStsid.Items.Clear()
        
        clear()
        st.combo(cmbStsid)

    End Sub


    Private Sub btnSupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupdate.Click
        supp.s_names = txtSname.Text
        supp.s_phones = txtSname.Text
        supp.s_inames = txtSitemname.Text
        supp.s_descs = txtSitemDesc.Text
        Try
            supp.supplier_update()
        Catch ex As Exception
            MsgBox("error")
        End Try
        supp.ShowTable(supplierdatagrid)
        clear()
    End Sub

    Private Sub btnSdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSdel.Click
        supp.s_ids.ToString()
        supp.supplier_delete()
        supp.ShowTable(supplierdatagrid)
        clear()
    End Sub

    Private Sub supplierdatagrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles supplierdatagrid.CellContentClick
        supp.s_ids = supplierdatagrid(0, supplierdatagrid.CurrentRow.Index).Value
        txtSname.Text = supplierdatagrid(1, supplierdatagrid.CurrentRow.Index).Value
        txtScont.Text = supplierdatagrid(2, supplierdatagrid.CurrentRow.Index).Value
    End Sub

    Private Sub cmbCustname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustname.SelectedIndexChanged
        ord.getcustnames(cmbCustname, Label13)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ord.GetItemnames(txtdesc, txtpr, ComboBox1, Label12)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ord.quantitys = NumericUpDown1.Value
        ord.itemids = Label12.Text
        ord.custids = Label13.Text
        ord.odates = dateorder.Text
        ord.ocosts = txttotal.Text
        ord.oamounts = txtamount.Text
        ord.ochanges = txtchange.Text
        Try
            ord.ordercustomer(dtgorder)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        st.ShowTable(stockdatagrid)
        itm.ShowTable(itemdatagrid)
        clear()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ord.dtgrid(Label12, ComboBox1, txtdesc, txtpr, NumericUpDown1, txttotal, dtgorder)

    End Sub


    Private Sub btnstcrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstcrt.Click
        st.sp_ids = CInt(cmbStsid.Text)
        st.st_dates = CDate(datestock.Text)
        st.prices = CDbl(txtSttotalprice.Text)
        st.ct_descs = CStr(txtstdesc.Text)
        st.st_names = CStr(txtstitemname.Text)
        st.st_qtys = CInt(txtstqty.Text)
        st.st_prs = ((txtSttotalprice.Text / txtstqty.Text) * 0.2 + (txtSttotalprice.Text / txtstqty.Text))

        Try
            st.stock_add()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        st.ShowTable(stockdatagrid)
        itm.ShowTable(itemdatagrid)
        ComboBox1.Items.Clear()
        ord.GetItemnamesz(ComboBox1)
        clear()
        ComboBox2.Items.Clear()
        st.item(ComboBox2)
    End Sub

    
    Private Sub cmbStsid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStsid.SelectedIndexChanged
        st.show(txtstitemname, txtstdesc, cmbStsid)
    End Sub

    
    Private Sub btnIupdt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIupdt.Click
        itm.itm_ids = TextBox1.Text
        itm.itm_categs = txtIitemname.Text
        itm.itm_descs = txtiitemdesc.Text
        itm.itm_prs = txtiitemprice.Text
        itm.itm_qtys = txtitemquantity.Text
        Try
            itm.item_update()
        Catch ex As Exception
            MsgBox("error")
        End Try
        itm.ShowTable(itemdatagrid)
        clear()
    End Sub

   
    Private Sub btnIdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        itm.itm_ids = TextBox1.Text

        itm.ShowTable(itemdatagrid)
        clear()
    End Sub

    Private Sub itemdatagrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles itemdatagrid.CellContentClick
        TextBox1.Text = itemdatagrid(0, itemdatagrid.CurrentRow.Index).Value
        txtIitemname.Text = itemdatagrid(1, itemdatagrid.CurrentRow.Index).Value
        txtiitemdesc.Text = itemdatagrid(2, itemdatagrid.CurrentRow.Index).Value
        txtiitemprice.Text = itemdatagrid(3, itemdatagrid.CurrentRow.Index).Value
        txtitemquantity.Text = itemdatagrid(4, itemdatagrid.CurrentRow.Index).Value
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label25.Text = Date.Now.ToString("MM-dd-yyyy  hh:mm:ss")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
    End Sub
 
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ord.cancel(dtgorder)
        st.ShowTable(stockdatagrid)
        itm.ShowTable(itemdatagrid)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtchange.Text = txtamount.Text - txttotal.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ord.records(dtgorecords)
        dtgorecords.DataSource.clear()
        ord.records(dtgorecords)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Receipt.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        st.stockr(dtgst)
        dtgst.DataSource.clear()
        st.stockr(dtgst)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form3.ShowDialog()
    End Sub


    Private Sub btnstdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstdel.Click
        st.st_qtys = CInt(txtstqty.Text)
        st.i_ids = ComboBox2.Text
        st.stock_delete()
        st.ShowTable(stockdatagrid)
        itm.ShowTable(itemdatagrid)
        clear()

    End Sub

    Private Sub stockdatagrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles stockdatagrid.CellContentClick
        st.st_ids = stockdatagrid(0, stockdatagrid.CurrentRow.Index).Value
        cmbStsid.Text = stockdatagrid(1, stockdatagrid.CurrentRow.Index).Value
        ComboBox2.Text = stockdatagrid(2, stockdatagrid.CurrentRow.Index).Value
        datestock.Text = stockdatagrid(3, stockdatagrid.CurrentRow.Index).Value
        txtSttotalprice.Text = stockdatagrid(4, stockdatagrid.CurrentRow.Index).Value
        txtstqty.Text = stockdatagrid(5, stockdatagrid.CurrentRow.Index).Value
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        st.sp_ids = cmbStsid.Text
        st.i_ids = ComboBox2.Text
        st.st_dates = datestock.Text
        st.st_prs = txtSttotalprice.Text
        st.st_qtys = txtstqty.Text
        st.restock()
        st.ShowTable(stockdatagrid)
        itm.ShowTable(itemdatagrid)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        st.items(txtstitemname, txtstdesc, ComboBox2)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        strecords.ShowDialog()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form6.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Form7.ShowDialog()
    End Sub

  
End Class
