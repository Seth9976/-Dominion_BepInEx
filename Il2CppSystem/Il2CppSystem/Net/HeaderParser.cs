using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DF RID: 223
	public sealed class HeaderParser : MulticastDelegate
	{
		// Token: 0x06000CEE RID: 3310 RVA: 0x00041604 File Offset: 0x0003F804
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderParser()
		{
			Il2CppClassPointerStore<HeaderParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderParser");
			HeaderParser.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderParser>.NativeClassPtr, 100665130);
			HeaderParser.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderParser>.NativeClassPtr, 100665131);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00041654 File Offset: 0x0003F854
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderParser(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderParser.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000416B0 File Offset: 0x0003F8B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37559, RefRangeEnd = 37564, XrefRangeStart = 37559, XrefRangeEnd = 37564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Invoke(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderParser.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00007022 File Offset: 0x00005222
		public HeaderParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0000702B File Offset: 0x0000522B
		public static implicit operator HeaderParser(Func<string, Il2CppStringArray> A_0)
		{
			return DelegateSupport.ConvertDelegate<HeaderParser>(A_0);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00007033 File Offset: 0x00005233
		public static HeaderParser operator +(HeaderParser A_0, HeaderParser A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HeaderParser>();
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00007041 File Offset: 0x00005241
		public static HeaderParser operator -(HeaderParser A_0, HeaderParser A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HeaderParser>();
			}
			return delegate2;
		}

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStringArray_String_0;
	}
}
