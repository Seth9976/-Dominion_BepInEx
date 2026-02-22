using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x02000123 RID: 291
	[StructLayout(2)]
	public struct PreUpdate
	{
		// Token: 0x06001727 RID: 5927 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
		// Note: this type is marked as 'beforefieldinit'.
		static PreUpdate()
		{
			Il2CppClassPointerStore<PreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0000CFE9 File Offset: 0x0000B1E9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x02000910 RID: 2320
		[StructLayout(2)]
		public struct PhysicsUpdate
		{
			// Token: 0x06003021 RID: 12321 RVA: 0x00016783 File Offset: 0x00014983
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003022 RID: 12322 RVA: 0x000167A3 File Offset: 0x000149A3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000911 RID: 2321
		[StructLayout(2)]
		public struct Physics2DUpdate
		{
			// Token: 0x06003023 RID: 12323 RVA: 0x000167B5 File Offset: 0x000149B5
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "Physics2DUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr);
			}

			// Token: 0x06003024 RID: 12324 RVA: 0x000167D5 File Offset: 0x000149D5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000912 RID: 2322
		[StructLayout(2)]
		public struct CheckTexFieldInput
		{
			// Token: 0x06003025 RID: 12325 RVA: 0x000167E7 File Offset: 0x000149E7
			// Note: this type is marked as 'beforefieldinit'.
			static CheckTexFieldInput()
			{
				Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "CheckTexFieldInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr);
			}

			// Token: 0x06003026 RID: 12326 RVA: 0x00016807 File Offset: 0x00014A07
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000913 RID: 2323
		[StructLayout(2)]
		public struct IMGUISendQueuedEvents
		{
			// Token: 0x06003027 RID: 12327 RVA: 0x00016819 File Offset: 0x00014A19
			// Note: this type is marked as 'beforefieldinit'.
			static IMGUISendQueuedEvents()
			{
				Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "IMGUISendQueuedEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr);
			}

			// Token: 0x06003028 RID: 12328 RVA: 0x00016839 File Offset: 0x00014A39
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000914 RID: 2324
		[StructLayout(2)]
		public struct SendMouseEvents
		{
			// Token: 0x06003029 RID: 12329 RVA: 0x0001684B File Offset: 0x00014A4B
			// Note: this type is marked as 'beforefieldinit'.
			static SendMouseEvents()
			{
				Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "SendMouseEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr);
			}

			// Token: 0x0600302A RID: 12330 RVA: 0x0001686B File Offset: 0x00014A6B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000915 RID: 2325
		[StructLayout(2)]
		public struct AIUpdate
		{
			// Token: 0x0600302B RID: 12331 RVA: 0x0001687D File Offset: 0x00014A7D
			// Note: this type is marked as 'beforefieldinit'.
			static AIUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "AIUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr);
			}

			// Token: 0x0600302C RID: 12332 RVA: 0x0001689D File Offset: 0x00014A9D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000916 RID: 2326
		[StructLayout(2)]
		public struct WindUpdate
		{
			// Token: 0x0600302D RID: 12333 RVA: 0x000168AF File Offset: 0x00014AAF
			// Note: this type is marked as 'beforefieldinit'.
			static WindUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "WindUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr);
			}

			// Token: 0x0600302E RID: 12334 RVA: 0x000168CF File Offset: 0x00014ACF
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000917 RID: 2327
		[StructLayout(2)]
		public struct UpdateVideo
		{
			// Token: 0x0600302F RID: 12335 RVA: 0x000168E1 File Offset: 0x00014AE1
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateVideo()
			{
				Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "UpdateVideo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr);
			}

			// Token: 0x06003030 RID: 12336 RVA: 0x00016901 File Offset: 0x00014B01
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000918 RID: 2328
		[StructLayout(2)]
		public struct NewInputUpdate
		{
			// Token: 0x06003031 RID: 12337 RVA: 0x00016913 File Offset: 0x00014B13
			// Note: this type is marked as 'beforefieldinit'.
			static NewInputUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "NewInputUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr);
			}

			// Token: 0x06003032 RID: 12338 RVA: 0x00016933 File Offset: 0x00014B33
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
