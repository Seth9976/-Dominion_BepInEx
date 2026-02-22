using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000176 RID: 374
	public sealed class FileDetailsResult_t : ValueType
	{
		// Token: 0x060020D4 RID: 8404 RVA: 0x0009F98C File Offset: 0x0009DB8C
		// Note: this type is marked as 'beforefieldinit'.
		static FileDetailsResult_t()
		{
			Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FileDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr);
			FileDetailsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "k_iCallback");
			FileDetailsResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_eResult");
			FileDetailsResult_t.NativeFieldInfoPtr_m_ulFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_ulFileSize");
			FileDetailsResult_t.NativeFieldInfoPtr_m_FileSHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_FileSHA");
			FileDetailsResult_t.NativeFieldInfoPtr_m_unFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr, "m_unFlags");
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0000BCE6 File Offset: 0x00009EE6
		public FileDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x0000BCEF File Offset: 0x00009EEF
		public FileDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0009FA20 File Offset: 0x0009DC20
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x0000BD01 File Offset: 0x00009F01
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FileDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0009FA3C File Offset: 0x0009DC3C
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x0000BD0F File Offset: 0x00009F0F
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x0009FA64 File Offset: 0x0009DC64
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x0000BD2A File Offset: 0x00009F2A
		public unsafe ulong m_ulFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_ulFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_ulFileSize)) = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0009FA8C File Offset: 0x0009DC8C
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x0000BD45 File Offset: 0x00009F45
		public unsafe Il2CppStructArray<byte> m_FileSHA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_FileSHA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_FileSHA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x0009FABC File Offset: 0x0009DCBC
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x0000BD64 File Offset: 0x00009F64
		public unsafe uint m_unFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_unFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetailsResult_t.NativeFieldInfoPtr_m_unFlags)) = value;
			}
		}

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_m_ulFileSize;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_m_FileSHA;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeFieldInfoPtr_m_unFlags;
	}
}
