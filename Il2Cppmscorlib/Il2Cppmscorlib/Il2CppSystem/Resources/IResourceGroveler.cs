using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200017C RID: 380
	public class IResourceGroveler : Il2CppObjectBase
	{
		// Token: 0x06001A60 RID: 6752 RVA: 0x00008FCC File Offset: 0x000071CC
		// Note: this type is marked as 'beforefieldinit'.
		static IResourceGroveler()
		{
			Il2CppClassPointerStore<IResourceGroveler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "IResourceGroveler");
			IResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Abstract_Virtual_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceGroveler>.NativeClassPtr, 100667756);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00099D40 File Offset: 0x00097F40
		[CallerCount(0)]
		public unsafe virtual ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localResourceSets);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParents;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNotExists;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceGroveler.NativeMethodInfoPtr_GrovelForResourceSet_Public_Abstract_Virtual_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceSet>(intPtr3) : null;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00008FFB File Offset: 0x000071FB
		public IResourceGroveler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_GrovelForResourceSet_Public_Abstract_Virtual_New_ResourceSet_CultureInfo_Dictionary_2_String_ResourceSet_Boolean_Boolean_byref_StackCrawlMark_0;
	}
}
