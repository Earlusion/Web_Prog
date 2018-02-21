using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ListItem[] temp = buildAvailableCourseList();

        if (!Page.IsPostBack) //For initial page creation
        {

            ListItem[] availableCourses = buildAvailableCourseList();
            lbxAvailableClasses.DataSource = availableCourses;
            lbxAvailableClasses.DataTextField = "Text";
            lbxAvailableClasses.DataValueField = "Value";
            lbxAvailableClasses.DataBind();
        }
    }
    private ListItem[] buildAvailableCourseList()
    {
        ListItem[] tempList = {
                new ListItem("CS 1301-4", "CS 1301-4"),
                new ListItem("CS 1302-4", "CS 1302-4"),
                new ListItem("CS 1303-4", "CS 1303-4"),
                new ListItem("CS 2202-2", "CS 2202-2"),
                new ListItem("CS 2224-2", "CS 2224-2"),
                new ListItem("CS 3300-3", "CS 3300-3"),
                new ListItem("CS 3301-1", "CS 3301-1"),
                new ListItem("CS 3302-1", "CS 3302-1"),
                new ListItem("CS 3340-3", "CS 3340-3"),
                new ListItem("CS 4321-3", "CS 4321-3"),
                new ListItem("CS 4322-3", "CS 4322-3")
            };
        return tempList;
    }

    protected int Hour_Count()
    {
        int total = 0;

        foreach (ListItem i in lbxRegisteredClasses.Items)
        {
            Char delim = '-';
            String[] temp = i.Value.Split(delim);

            total += Int32.Parse(temp[1]);
        }

        return total;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        for (var i = 0; i < lbxAvailableClasses.Items.Count; i++)
        {

            ListItem temp = lbxAvailableClasses.Items[i];

            if (temp.Selected)
            {
                lbxRegisteredClasses.Items.Add(temp);
                lbxAvailableClasses.Items.Remove(temp);
            }
        }

        int hours = Hour_Count();
        double cost = hours * 100;

        lblHours.Text = hours.ToString();
        lblCost.Text = "$" + cost;
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {

        for (var i = 0; i < lbxRegisteredClasses.Items.Count; i++)
        {

            ListItem temp = lbxRegisteredClasses.Items[i];

            if (temp.Selected)
            {
                lbxAvailableClasses.Items.Add(temp);
                lbxRegisteredClasses.Items.Remove(temp);
            }
        }

        int hours = Hour_Count();
        double cost = hours * 100;

        lblHours.Text = hours.ToString();
        lblCost.Text = "$" + cost;
    }

    protected void reset(object sender, EventArgs e)
    {
        for (var i = 0; i < lbxRegisteredClasses.Items.Count; i++)
        {
            ListItem temp = lbxRegisteredClasses.Items[i];

            lbxAvailableClasses.Items.Add(temp);
            lbxRegisteredClasses.Items.Remove(temp);
        }
    }
}