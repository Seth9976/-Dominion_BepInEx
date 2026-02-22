using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200001E RID: 30
	public sealed class NativeArrayDebugView<T> : Object where T : new()
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000195EC File Offset: 0x000177EC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDebugView()
		{
			Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002A0B File Offset: 0x00000C0B
		public NativeArrayDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002A14 File Offset: 0x00000C14
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
