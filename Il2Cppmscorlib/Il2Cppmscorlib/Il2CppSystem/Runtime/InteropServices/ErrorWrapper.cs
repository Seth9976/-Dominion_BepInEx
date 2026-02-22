using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000452 RID: 1106
	[Serializable]
	public sealed class ErrorWrapper : Object
	{
		// Token: 0x060042F2 RID: 17138 RVA: 0x00019B6A File Offset: 0x00017D6A
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorWrapper()
		{
			Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ErrorWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr);
			ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr, "m_ErrorCode");
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00019BA3 File Offset: 0x00017DA3
		public ErrorWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x00133210 File Offset: 0x00131410
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x00019BAC File Offset: 0x00017DAC
		public unsafe int m_ErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode)) = value;
			}
		}

		// Token: 0x040036AF RID: 13999
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorCode;
	}
}
