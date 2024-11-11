



This Inventory Management System is designed to help you track the status of items (referred to as \textit{assets}) for each quote (represented by a \textit{quotation number}) in all of your branches\footnote{ We assume SJ Rollins has multiple branches in the US} at three distinct stages:

\begin{itemize}
    \item \textbf{Procurement:} When the items are ordered.
    \item \textbf{Acquisition:} When the items are received and staged in the warehouse.
    \item \textbf{Deployment:} When the items are delivered, deployed, or returned/edited.
\end{itemize}

The system offers a model that can be expanded and enhanced to meet specific needs, offering robust tracking and management of assets (items) across the entire life cycle. 

The entity-relationship (ER) diagram for the inventory management system involves the following entities and their relationships based on the primary and foreign keys:

\subsection*{Entities:}
\begin{enumerate}
    \item \textbf{VendorMaster}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{VMid}
        \item \textbf{Used In:} 
        \begin{itemize}
            \item \texttt{AssetProcurement} (\textit{ForeignKey: VendorMasterId})
            \item \texttt{AssetAquisation} (\textit{ForeignKey: VendorMasterId})
            \item \texttt{AssetDeployement} (\textit{ForeignKey: VendorMasterId})
        \end{itemize}
    \end{itemize}
    
    \item \textbf{Location}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{Lid}
        \item \textbf{Used In:}
        \begin{itemize}
            \item \texttt{Employee} (\textit{ForeignKey: LocationId})
        \end{itemize}
    \end{itemize}

    \item \textbf{Employee}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{Eid}
        \item \textbf{Used In:} 
        \begin{itemize}
            \item \texttt{AssetAquisation} (\textit{ForeignKey: EmployeeId})
            \item \texttt{AssetDeployement} (\textit{ForeignKey: EmployeeId})
        \end{itemize}
    \end{itemize}

    \item \textbf{Designation}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{Did}
        \item \textbf{Used In:}
        \begin{itemize}
            \item \texttt{Employee} (\textit{ForeignKey: DesignationId})
        \end{itemize}
    \end{itemize}

    \item \textbf{Department}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{Depid}
        \item \textbf{Used In:}
        \begin{itemize}
            \item \texttt{Employee} (\textit{ForeignKey: DepartmentId})
            \item \texttt{AssetDeployement} (\textit{ForeignKey: DepartmentId})
        \end{itemize}
    \end{itemize}

    \item \textbf{AssetProcurement}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{APid}
        \item \textbf{Foreign Keys:}
        \begin{itemize}
            \item \texttt{AssetMasterId} (links to \texttt{AssetMaster})
            \item \texttt{VendorMasterId} (links to \texttt{VendorMaster})
        \end{itemize}
    \end{itemize}

    \item \textbf{AssetMaster}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{AMid}
        \item \textbf{Used In:}
        \begin{itemize}
            \item \texttt{AssetProcurement} (\textit{ForeignKey: AssetMasterId})
            \item \texttt{AssetAquisation} (\textit{ForeignKey: AssetMasterId})
            \item \texttt{AssetDeployement} (\textit{ForeignKey: AssetMasterId})
        \end{itemize}
    \end{itemize}

    \item \textbf{AssetAquisation}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{AAid}
        \item \textbf{Foreign Keys:}
        \begin{itemize}
            \item \texttt{AssetMasterId} (links to \texttt{AssetMaster})
            \item \texttt{VendorMasterId} (links to \texttt{VendorMaster})
            \item \texttt{EmployeeId} (links to \texttt{Employee})
        \end{itemize}
    \end{itemize}

    \item \textbf{AssetDeployement}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{ADid}
        \item \textbf{Foreign Keys:}
        \begin{itemize}
            \item \texttt{AssetMasterId} (links to \texttt{AssetMaster})
            \item \texttt{VendorMasterId} (links to \texttt{VendorMaster})
            \item \texttt{EmployeeId} (links to \texttt{Employee})
            \item \texttt{DepartmentId} (links to \texttt{Department})
        \end{itemize}
    \end{itemize}

    \item \textbf{User}
    \begin{itemize}
        \item \textbf{Primary Key:} \texttt{Id}
        \item \textbf{Not linked to other tables as of now.}
    \end{itemize}
\end{enumerate}

\subsection*{ER Diagram Details\footnote{For the case of simplicity I just have used reverse navigation in those classes that have Foreign Keys}}
\textbf{One-to-Many Relationships:}
\begin{itemize}
    \item \textbf{Location} to \texttt{Employee} (one location can have many employees)
    \item \textbf{Designation} to \texttt{Employee} (one designation (title) can be assigned to  many employees)
    \item \textbf{Department} to \texttt{Employee} and \texttt{AssetDeployement} (one department can have many employees and many asset deployments)
    \item \textbf{VendorMaster} to \texttt{AssetProcurement}, \texttt{AssetAquisation}, and \texttt{AssetDeployement} (one vendor can provide multiple assets)
    \item \textbf{AssetMaster} to \texttt{AssetProcurement}, \texttt{AssetAquisation}, and \texttt{AssetDeployement} (one asset (item)  can go through multiple procurement, acquisition, and deployment processes)
\end{itemize}
