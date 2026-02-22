using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace TMPro
{
	// Token: 0x02000006 RID: 6
	public class ITextPreprocessor : Il2CppObjectBase
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000216C File Offset: 0x0000036C
		// Note: this type is marked as 'beforefieldinit'.
		static ITextPreprocessor()
		{
			Il2CppClassPointerStore<ITextPreprocessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ITextPreprocessor");
			ITextPreprocessor.NativeMethodInfoPtr_PreprocessText_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextPreprocessor>.NativeClassPtr, 100663313);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000A810 File Offset: 0x00008A10
		[CallerCount(0)]
		public unsafe virtual string PreprocessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextPreprocessor.NativeMethodInfoPtr_PreprocessText_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000219B File Offset: 0x0000039B
		public ITextPreprocessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessText_Public_Abstract_Virtual_New_String_String_0;
	}
}
