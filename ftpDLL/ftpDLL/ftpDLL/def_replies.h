//! 4.2.2 Numeric  Order List of Reply Codes

#define 110     // Restart marker reply.
                /*  In this case, the text is exact and not left to the particular implementation; it must read:
                    MARK yyyy = mmmm
                    Where yyyy is User-process data stream marker, and mmmm server's equivalent marker (note the spaces between markers and "=").
                */
#define 120     // Service ready in nnn minutes.
#define 125     // Data connection already open; transfer starting.
#define 150     // File status okay; about to open data connection.
#define 200     // Command okay.
#define 202     // Command not implemented, superfluous at this site.
#define 211     // System status, or system help reply.
#define 212     // Directory status.
#define 213     // File status.
#define 214     // Help message.On how to use the server or the meaning of a particular non-standard command.  This reply is useful only to the human user.
#define 215     // NAME system type. Where NAME is an official system name from the list in the Assigned Numbers document.
#define 220     // Service ready for new user.
#define 221     // Service closing control connection. Logged out if appropriate.
#define 225     // Data connection open; no transfer in progress.
#define 226     // Closing data connection. Requested file action successful (for example, file transfer or file abort).
#define 227     // Entering Passive Mode (h1,h2,h3,h4,p1,p2).
#define 230     // User logged in, proceed.
#define 250     // Requested file action okay, completed.
#define 257     // "PATHNAME" created.
#define 331     // User name okay, need password.
#define 332     // Need account for login.
#define 350     // Requested file action pending further information.
#define 421     // Service not available, closing control connection.This may be a reply to any command if the service knows it must shut down.
#define 425     // Can't open data connection.
#define 426     // Connection closed; transfer aborted.
#define 450     // Requested file action not taken. File unavailable (e.g., file busy).
#define 451     // Requested action aborted: local error in processing.
#define 452     // Requested action not taken. Insufficient storage space in system.
#define 500     // Syntax error, command unrecognized. This may include errors such as command line too long.
#define 501     // Syntax error in parameters or arguments.
#define 502     // Command not implemented.
#define 503     // Bad sequence of commands.
#define 504     // Command not implemented for that parameter.
#define 530     // Not logged in.
#define 532     // Need account for storing files.
#define 550     // Requested action not taken. File unavailable (e.g., file not found, no access).
#define 551     // Requested action aborted: page type unknown.
#define 552     // Requested file action aborted. Exceeded storage allocation (for current directory or dataset).
#define 553     // Requested action not taken.File name not allowed.
