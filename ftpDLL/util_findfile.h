#pragma once
#include <string>
#include <vector>

namespace utility {
	using namespace std;

	class findfile
	{
	protected:
		string				mstrTargetDir;				//! 対象ディレクトリ
		vector<string>		vFound;						//! ファイル名配列
		vector<_fsize_t>	vSize;						//! ファイルサイズ配列

	public:
		findfile();
		virtual ~findfile();

		int initialize(void);

		// ファイル削除
		static int	eraser(const char* pDir, const char* pName);

		// ファイル検索 & ファイルリード
		// finder() => getindex() => reader()
		int finder(const char* pDir, const char* pName);//! ファイル検索(ファイル名取得)

		const string&	get_filename(int siIndex) { return vFound[siIndex]; }
		_fsize_t	getsize(int siIndex) { return vSize[siIndex]; }
		_fsize_t	getsize(const char* pName);
		int			getindex(void);
		int			reader(const char* pName, char* pBuffer, int bufSize);
	
	protected:
		int variables(void);
	};
};

