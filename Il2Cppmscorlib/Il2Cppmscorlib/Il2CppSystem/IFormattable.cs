using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000BF RID: 191
	public class IFormattable : Il2CppObjectBase
	{
		// Token: 0x06000D0F RID: 3343 RVA: 0x0000579F File Offset: 0x0000399F
		// Note: this type is marked as 'beforefieldinit'.
		static IFormattable()
		{
			Il2CppClassPointerStore<IFormattable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IFormattable");
			IFormattable.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormattable>.NativeClassPtr, 100665480);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0005D450 File Offset: 0x0005B650
		[CallerCount(0)]
		public unsafe virtual string ToString(string format, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormattable.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_String_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000057CE File Offset: 0x000039CE
		public IFormattable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_String_IFormatProvider_0;
	}
}
