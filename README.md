

# Inventory Management System 

This Inventory Management System is designed to help you track the status of items (referred to as *assets*) for each quote (represented by a *quotation number*) across all of your branches (we assume the company has multiple branches in the US) at three distinct stages:

- **Procurement**: When the items are ordered.
- **Acquisition**: When the items are received and staged in the warehouse.
- **Deployment**: When the items are delivered, deployed, or returned/edited.


 By logging the system ((userid = 1, Password = RyanLove@@10), you can do CRUD operation as following
![CLocations_1](https://github.com/user-attachments/assets/e83727c5-240f-431c-8202-af480684f827)
 and 
![CAssets_2](https://github.com/user-attachments/assets/494d74a7-18d9-4765-b628-869c2f64a5c9)

and 
  ![Cdeplot_3](https://github.com/user-attachments/assets/16c4f985-03e5-44e9-8869-92215ba4c40a)

The system offers a model that can be expanded and enhanced to meet specific needs, providing robust tracking and management of assets across the entire life cycle.

## Entity-Relationship (ER) Diagram

The ER diagram for the Inventory Management System is structured around several key entities and their relationships, defined by primary and foreign keys.

### Entities

1. **VendorMaster**
   - **Primary Key**: `VMid`
   - **Used In**:
     - `AssetProcurement` (*ForeignKey: VendorMasterId*)
     - `AssetAcquisition` (*ForeignKey: VendorMasterId*)
     - `AssetDeployment` (*ForeignKey: VendorMasterId*)

2. **Location**
   - **Primary Key**: `Lid`
   - **Used In**:
     - `Employee` (*ForeignKey: LocationId*)

3. **Employee**
   - **Primary Key**: `Eid`
   - **Used In**:
     - `AssetAcquisition` (*ForeignKey: EmployeeId*)
     - `AssetDeployment` (*ForeignKey: EmployeeId*)

4. **Designation**
   - **Primary Key**: `Did`
   - **Used In**:
     - `Employee` (*ForeignKey: DesignationId*)

5. **Department**
   - **Primary Key**: `Depid`
   - **Used In**:
     - `Employee` (*ForeignKey: DepartmentId*)
     - `AssetDeployment` (*ForeignKey: DepartmentId*)

6. **AssetProcurement**
   - **Primary Key**: `APid`
   - **Foreign Keys**:
     - `AssetMasterId` (links to `AssetMaster`)
     - `VendorMasterId` (links to `VendorMaster`)

7. **AssetMaster**
   - **Primary Key**: `AMid`
   - **Used In**:
     - `AssetProcurement` (*ForeignKey: AssetMasterId*)
     - `AssetAcquisition` (*ForeignKey: AssetMasterId*)
     - `AssetDeployment` (*ForeignKey: AssetMasterId*)

8. **AssetAcquisition**
   - **Primary Key**: `AAid`
   - **Foreign Keys**:
     - `AssetMasterId` (links to `AssetMaster`)
     - `VendorMasterId` (links to `VendorMaster`)
     - `EmployeeId` (links to `Employee`)

9. **AssetDeployment**
   - **Primary Key**: `ADid`
   - **Foreign Keys**:
     - `AssetMasterId` (links to `AssetMaster`)
     - `VendorMasterId` (links to `VendorMaster`)
     - `EmployeeId` (links to `Employee`)
     - `DepartmentId` (links to `Department`)

10. **User**
    - **Primary Key**: `Id`
    - *Not linked to other tables as of now.*

### ER Diagram Details

#### One-to-Many Relationships

- **Location** to `Employee` (one location can have many employees)
- **Designation** to `Employee` (one designation can be assigned to many employees)
- **Department** to `Employee` and `AssetDeployment` (one department can have many employees and asset deployments)
- **VendorMaster** to `AssetProcurement`, `AssetAcquisition`, and `AssetDeployment` (one vendor can provide multiple assets)
- **AssetMaster** to `AssetProcurement`, `AssetAcquisition`, and `AssetDeployment` (one asset can go through multiple procurement, acquisition, and deployment processes)

---

This structure provides a comprehensive overview of the system's data model, allowing efficient tracking and management of assets across multiple branches and stages. 

--- 

Let me know if you'd like further adjustments to suit any specific requirements for the README file.
